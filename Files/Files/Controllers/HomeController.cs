using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Files.DAL;
using Files.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Files.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // GET: Properties/Search
        public IActionResult Search()
        {
            // Populate dropdowns for categories
            ViewBag.AllCategories = GetAllCategoriesSelectList();

            // Initialize search view model with defaults
            var svm = new SearchViewModel
            {
                MinGuests = 0,
                MaxGuests = 15,
                MinPrice = 0.0m,
                MaxPrice = 300.0m,
                SelectedCategoryID = 0, // Default: All categories
                MinRating = 1.0m,
                MaxRating = 5.0m
            };

            return View(svm);
        }

        // GET: Properties/Results
        public IActionResult DisplaySearchResults(SearchViewModel svm)
        {
            // Start with the full list of properties
            IQueryable<Property> query = _context.Properties
                .Include(p => p.Categories)
                .Include(p => p.Reviews); // Include Reviews for GuestRating calculations

            // City search
            if (!string.IsNullOrEmpty(svm.City))
            {
                query = query.Where(p => p.City.Contains(svm.City));
            }

            // State search
            if (!string.IsNullOrEmpty(svm.State))
            {
                query = query.Where(p => p.State.Contains(svm.State));
            }

            // Filter by guests
            if (svm.MinGuests.HasValue)
            {
                query = query.Where(p => p.GuestsAllowed >= svm.MinGuests.Value);
            }

            if (svm.MaxGuests.HasValue)
            {
                query = query.Where(p => p.GuestsAllowed <= svm.MaxGuests.Value);
            }

            // Filter by price
            if (svm.MinPrice.HasValue)
            {
                query = query.Where(p => p.WeekdayPrice >= svm.MinPrice.Value);
            }

            if (svm.MaxPrice.HasValue)
            {
                query = query.Where(p => p.WeekdayPrice <= svm.MaxPrice.Value);
            }

            // Filter by bedrooms
            if (svm.MinBedrooms.HasValue)
            {
                query = query.Where(p => p.Bedrooms >= svm.MinBedrooms.Value);
            }

            if (svm.MaxBedrooms.HasValue)
            {
                query = query.Where(p => p.Bedrooms <= svm.MaxBedrooms.Value);
            }

            // Filter by bathrooms
            if (svm.MinBathrooms.HasValue)
            {
                query = query.Where(p => p.Bathrooms >= svm.MinBathrooms.Value);
            }

            if (svm.MaxBathrooms.HasValue)
            {
                query = query.Where(p => p.Bathrooms <= svm.MaxBathrooms.Value);
            }

            // Filter by pets allowed
            if (svm.PetsAllowed.HasValue)
            {
                query = query.Where(p => p.PetsAllowed == svm.PetsAllowed.Value);
            }

            // Filter by free parking
            if (svm.FreeParking.HasValue)
            {
                query = query.Where(p => p.FreeParking == svm.FreeParking.Value);
            }

            // Filter by guest rating range
            if (svm.MinRating.HasValue)
            {
                query = query.Where(p => p.Reviews.Any() ? (decimal)p.Reviews.Average(r => r.Rating) >= svm.MinRating.Value : false);
            }

            if (svm.MaxRating.HasValue)
            {
                query = query.Where(p => p.Reviews.Any() ? (decimal)p.Reviews.Average(r => r.Rating) <= svm.MaxRating.Value : false);
            }

            // Filter by category
            if (svm.SelectedCategoryID != 0)
            {
                query = query.Where(p => p.Categories.CategoryID == svm.SelectedCategoryID);
            }

            // Check-in and Check-out date filters
            if (svm.CheckInDate.HasValue && svm.CheckOutDate.HasValue)
            {
                query = query.Where(p => !p.UnavailableDates.Any(d => d >= svm.CheckInDate && d <= svm.CheckOutDate));
            }

            // Execute the query and materialize the results
            var results = query.Select(p => new PropertyViewModel
            {
                PropertyID = p.PropertyID,
                Street = p.Street,
                City = p.City,
                State = p.State,
                Bedrooms = p.Bedrooms,
                Bathrooms = p.Bathrooms,
                GuestsAllowed = p.GuestsAllowed,
                WeekdayPrice = p.WeekdayPrice,
                Category = p.Categories.CategoryName,
                GuestRating = p.Reviews.Any() ? p.Reviews.Average(r => r.Rating) : 0 // Calculate average rating
            }).ToList();

            // Populate ViewBag with counts
            ViewBag.AllProperties = _context.Properties.Count();
            ViewBag.SelectedProperties = results.Count;

            // Return the results
            return View("Results", results.OrderBy(p => p.City).ThenBy(p => p.State));
        }

        private SelectList GetAllCategoriesSelectList()
        {
            // Retrieve categories from the database
            var categories = _context.Categories.ToList();

            // Add an "All" option at the top of the dropdown
            categories.Add(new Category { CategoryID = 0, CategoryName = "All" });

            // Return as a SelectList
            return new SelectList(categories.OrderBy(c => c.CategoryName), "CategoryID", "CategoryName");
        }

        [Authorize(Roles = "Host")]
        public IActionResult HostReports(DateTime? startDate, DateTime? endDate)
        {
            // Get the logged-in user's ID
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Pull properties and reservations into memory
            var properties = _context.Properties
                .Where(p => p.AppUsers.Id == userId)
                .Include(p => p.Reservations) // Ensure Reservations are loaded
                .ToList(); // Bring data into memory

            // Process the data in memory
            var reports = properties.Select(p => new HostReport
            {
                Street = p.Street,
                PropertyNumber = p.PropertyNumber,
                TotalStayRevenue = p.Reservations
                    .Where(r => (!startDate.HasValue || r.CheckIn >= startDate) &&
                                (!endDate.HasValue || r.CheckOut <= endDate))
                    .Sum(r => r.CalculateStayPrice() * 0.9m), // Apply method in memory
                TotalCleaningFees = p.Reservations
                    .Where(r => (!startDate.HasValue || r.CheckIn >= startDate) &&
                                (!endDate.HasValue || r.CheckOut <= endDate))
                    .Sum(r => r.CleaningFee),
                TotalCombinedRevenue = p.Reservations
                    .Where(r => (!startDate.HasValue || r.CheckIn >= startDate) &&
                                (!endDate.HasValue || r.CheckOut <= endDate))
                    .Sum(r => (r.CalculateStayPrice() * 0.9m) + r.CleaningFee),
                TotalReservations = p.Reservations
                    .Where(r => (!startDate.HasValue || r.CheckIn >= startDate) &&
                                (!endDate.HasValue || r.CheckOut <= endDate))
                    .Count()
            }).ToList();

            // Prepare the view model
            var model = new HostReportViewModel
            {
                StartDate = startDate ?? DateTime.Now.AddMonths(-1),
                EndDate = endDate ?? DateTime.Now,
                Reports = reports
            };

            return View(model);
        }
    }
}