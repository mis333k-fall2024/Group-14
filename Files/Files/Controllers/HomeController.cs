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
                GuestValue = null,  // Default to null (no value)
                PriceValue = null,   // Default to null (no value)
                SelectedCategoryID = 0, // Default: All categories
                RatingValue = null   // Default to null (no value)
            };

            return View(svm);
        }

        // GET: Properties/Results
        public IActionResult DisplaySearchResults(SearchViewModel svm)
        {
            // Check if the model is valid before proceeding
            if (!ModelState.IsValid)
            {
                // Re-populate dropdowns or other view data
                ViewBag.AllCategories = GetAllCategoriesSelectList();

                // Return to the search view with the validation errors
                return View("Search", svm);
            }

            // Validate Check-In and Check-Out Dates
            if ((svm.CheckInDate.HasValue && !svm.CheckOutDate.HasValue) ||
                (!svm.CheckInDate.HasValue && svm.CheckOutDate.HasValue))
            {
                // Add a custom validation error
                ModelState.AddModelError("", "Both Check-In and Check-Out dates must be provided or left blank.");
                ViewBag.AllCategories = GetAllCategoriesSelectList();
                return View("Search", svm);
            }


            // Start with the full list of properties
            IQueryable<Property> query = _context.Properties
                .Include(p => p.Categories)
                .Include(p => p.Reviews);


            // Check-In and Check-Out Date filter
            if (svm.CheckInDate.HasValue && svm.CheckOutDate.HasValue)
            {
                DateTime checkInDate = svm.CheckInDate.Value;
                DateTime checkOutDate = svm.CheckOutDate.Value;

                // Filter properties with no unavailable dates or conflicting reservations
                query = query.Where(p =>
                    !p.UnavailableDates.Any(d => d >= checkInDate && d <= checkOutDate) &&
                    !p.Reservations.Any(r =>
                        (r.CheckIn < checkOutDate && r.CheckOut > checkInDate))); // Conflicting reservation logic
            }

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

            // Guests comparison
            if (svm.GuestValue.HasValue)
            {
                if (svm.GuestComparison == ComparisonType.GreaterThan)
                {
                    query = query.Where(p => p.GuestsAllowed >= svm.GuestValue.Value);
                }
                else if (svm.GuestComparison == ComparisonType.LessThan)
                {
                    query = query.Where(p => p.GuestsAllowed <= svm.GuestValue.Value);
                }
                else
                {
                    // Default to Equal To if no radio button is selected
                    query = query.Where(p => p.GuestsAllowed == svm.GuestValue.Value);
                }
            }

            // Price comparison
            if (svm.PriceValue.HasValue)
            {
                if (svm.PriceComparison == ComparisonType.GreaterThan)
                {
                    query = query.Where(p => p.WeekdayPrice >= svm.PriceValue.Value || p.WeekendPrice >= svm.PriceValue.Value);
                }
                else if (svm.PriceComparison == ComparisonType.LessThan)
                {
                    query = query.Where(p => p.WeekdayPrice <= svm.PriceValue.Value || p.WeekendPrice <= svm.PriceValue.Value);
                }
                else
                {
                    // Default to Equal To if no radio button is selected
                    query = query.Where(p => p.WeekdayPrice == svm.PriceValue.Value || p.WeekendPrice == svm.PriceValue.Value);
                }
            }

            // Bedrooms comparison
            if (svm.BedroomValue.HasValue)
            {
                if (svm.BedroomComparison == ComparisonType.GreaterThan)
                {
                    query = query.Where(p => p.Bedrooms >= svm.BedroomValue.Value);
                }
                else if (svm.BedroomComparison == ComparisonType.LessThan)
                {
                    query = query.Where(p => p.Bedrooms <= svm.BedroomValue.Value);
                }
                else
                {
                    // Default to Equal To if no radio button is selected
                    query = query.Where(p => p.Bedrooms == svm.BedroomValue.Value);
                }
            }

            // Bathrooms comparison
            if (svm.BathroomValue.HasValue)
            {
                if (svm.BathroomComparison == ComparisonType.GreaterThan)
                {
                    query = query.Where(p => p.Bathrooms >= svm.BathroomValue.Value);
                }
                else if (svm.BathroomComparison == ComparisonType.LessThan)
                {
                    query = query.Where(p => p.Bathrooms <= svm.BathroomValue.Value);
                }
                else
                {
                    // Default to Equal To if no radio button is selected
                    query = query.Where(p => p.Bathrooms == svm.BathroomValue.Value);
                }
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

            //guestrating
            if (svm.RatingValue.HasValue)
            {
                if (svm.RatingComparison == ComparisonType.GreaterThan)
                {
                    query = query.Where(p => p.Reviews.Any() ? (decimal)p.Reviews.Average(r => r.Rating) >= svm.RatingValue.Value : false);
                }
                else if (svm.RatingComparison == ComparisonType.LessThan)
                {
                    query = query.Where(p => p.Reviews.Any() ? (decimal)p.Reviews.Average(r => r.Rating) <= svm.RatingValue.Value : false);
                }
                else
                {
                    // Default behavior: Equal to comparison if no radio button is selected
                    query = query.Where(p => p.Reviews.Any() ? (decimal)p.Reviews.Average(r => r.Rating) == svm.RatingValue.Value : false);
                }
            }

            // Filter by category
            if (svm.SelectedCategoryID != 0)
            {
                query = query.Where(p => p.Categories.CategoryID == svm.SelectedCategoryID);
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
                WeekendPrice = p.WeekendPrice,
                Category = p.Categories.CategoryName,
                GuestRating = p.Reviews.Any() ? (decimal?)p.Reviews.Average(r => r.Rating) : null // Return null if no reviews
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
                    .Where(r => (!startDate.HasValue || !endDate.HasValue ||
                                 r.CheckIn <= endDate && r.CheckOut >= startDate))
                    .Sum(r => r.CalculateStayPrice() * 0.9m), // Apply method in memory
                TotalCleaningFees = p.Reservations
                    .Where(r => (!startDate.HasValue || !endDate.HasValue ||
                                 r.CheckIn <= endDate && r.CheckOut >= startDate))
                    .Sum(r => r.CleaningFee),
                TotalCombinedRevenue = p.Reservations
                    .Where(r => (!startDate.HasValue || !endDate.HasValue ||
                                 r.CheckIn <= endDate && r.CheckOut >= startDate))
                    .Sum(r => (r.CalculateStayPrice() * 0.9m) + r.CleaningFee),
                TotalReservations = p.Reservations
                    .Where(r => (!startDate.HasValue || !endDate.HasValue ||
                                 r.CheckIn <= endDate && r.CheckOut >= startDate))
                    .Count(),
                 Reservations = p.Reservations
                     .Where(r => (!startDate.HasValue || !endDate.HasValue ||
                     r.CheckIn <= endDate && r.CheckOut >= startDate))
        .ToList() // Ensure reservations are included
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

//cancel res for host
        [Authorize(Roles = "Host")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CancelRes(int id)
        {
            // Log or debug the incoming ID
            if (id == 0)
            {
                return Content("Invalid reservation ID.");
            }

            var reservation = await _context.Reservations
                .Include(r => r.Properties)
                .FirstOrDefaultAsync(r => r.ReservationID == id);

            if (reservation == null)
            {
                return Content("Reservation not found.");
            }

            // Check if cancellation is allowed
            if (reservation.CheckIn <= DateTime.Now)
            {
                return Content("Cannot cancel past reservations.");
            }

            // Pass the cancellation details to the view
            ViewBag.Title = "Reservation Canceled";
            ViewBag.ReservationId = reservation.ReservationID;
            ViewBag.Message = "Your reservation has been canceled successfully.";

            return View("CancellationConfirmation");
        }



        [Authorize(Roles = "Admin")]
        public IActionResult AdminReports(DateTime? startDate, DateTime? endDate)
        {
            // Bring necessary data into memory
            var reservations = _context.Reservations
                .Include(r => r.Properties) // Ensure navigation property is loaded
                .Where(r => !startDate.HasValue || !endDate.HasValue ||
                            r.CheckIn <= endDate && r.CheckOut >= startDate)
                .ToList();

            // Process report data
            var report = new AdminReport
            {
                TotalCommissionEarned = reservations.Sum(r => r.CalculateStayPrice() * 0.1m), // 10% commission
                TotalNumberOfReservations = reservations.Count(),
                AverageCommissionPerReservation = reservations.Any()
                    ? reservations.Average(r => r.CalculateStayPrice() * 0.1m)
                    : 0m,
                TotalNumberOfProperties = _context.Properties.Count()
            };

            // Prepare the view model
            var model = new AdminReportViewModel
            {
                StartDate = startDate ?? DateTime.Now.AddMonths(-1),
                EndDate = endDate ?? DateTime.Now,
                Report = report
            };

            return View(model);
        }

    }
}
