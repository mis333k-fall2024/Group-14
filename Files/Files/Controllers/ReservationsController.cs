using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Files.DAL;
using Files.Models;
using Files.Utilities;

namespace Files.Controllers
{
    [Authorize]
    public class ReservationsController : Controller
    {
        private readonly AppDbContext _context;

        public ReservationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reservations.Include(r => r.AppUsers).Include(r => r.Properties).ToListAsync());
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(r => r.AppUsers)
                .Include(r => r.Properties)
                .FirstOrDefaultAsync(m => m.ReservationID == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Cart
        [AllowAnonymous]
        public IActionResult Cart()
        {
            var reservations = HttpContext.Session.GetObjectFromJson<ReservationList>("Reservations") ?? new ReservationList();
            return View(reservations);
        }

        // POST: Reservations/AddToCart
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddToCart(int propertyId, DateTime checkIn, DateTime checkOut, int numOfGuests)
        {
            var reservationList = HttpContext.Session.GetObjectFromJson<ReservationList>("Reservations") ?? new ReservationList();

            var property = _context.Properties.FirstOrDefault(p => p.PropertyID == propertyId);
            if (property == null)
            {
                return NotFound("Property not found.");
            }

            // Check for overlapping reservations
            var isOverlapping = _context.Reservations.Any(r => r.Properties.PropertyID == propertyId &&
                                                               r.CheckIn < checkOut &&
                                                               r.CheckOut > checkIn);
            if (isOverlapping)
            {
                TempData["Error"] = "This property is already reserved for the selected dates.";
                return RedirectToAction("Cart");
            }

            var reservation = new Reservation
            {
                CheckIn = checkIn,
                CheckOut = checkOut,
                NumOfGuests = numOfGuests,
                WeekdayPrice = property.WeekdayPrice,
                WeekendPrice = property.WeekendPrice,
                CleaningFee = property.CleaningFee,
                DiscountRate = property.DiscountRate ?? 0m,
                Properties = property
            };

            // Calculate Total Amount
            var TotalAmount = reservation.CalculateTotalAmount();

            reservationList.Reservations.Add(reservation);
            HttpContext.Session.SetObjectAsJson("Reservations", reservationList);

            return RedirectToAction("Cart");
        }

        // POST: Reservations/Confirm
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Confirm()
        {
            var userId = User.Identity.Name;

            var reservations = await _context.Reservations
                .Where(r => r.AppUsers.UserName == userId && !r.ReservationStatus)
                .ToListAsync();

            if (!reservations.Any())
            {
                TempData["Error"] = "Your cart is empty. Please add reservations before confirming.";
                return RedirectToAction("Cart");
            }

            foreach (var reservation in reservations)
            {
                reservation.ReservationStatus = true;
            }

            await _context.SaveChangesAsync();

            TempData["Message"] = "Your reservations have been confirmed!";
            return RedirectToAction("ThankYou");
        }

        public IActionResult ThankYou()
        {
            return View();
        }

        // --- Admin Functionality to Make Reservations for Customers ---

        // GET: Reservations/MakeReservation
        [Authorize(Roles = "Admin")]
        public IActionResult MakeReservation()
        {
            return View(new ReservationViewModel());
        }

        // POST: Reservations/MakeReservation
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> MakeReservation(ReservationViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Validate Customer Profile
                var customer = await _context.Users.FirstOrDefaultAsync(u => u.Id == model.CustomerId);
                if (customer == null)
                {
                    ModelState.AddModelError("", "Customer not found. Ensure the customer has a valid profile.");
                    return View(model);
                }

                // Validate Property
                var property = await _context.Properties.FirstOrDefaultAsync(p => p.PropertyID == model.PropertyId);
                if (property == null)
                {
                    ModelState.AddModelError("", "Property not found.");
                    return View(model);
                }

                // Check for overlapping reservations
                var isOverlapping = _context.Reservations.Any(r => r.Properties.PropertyID == model.PropertyId &&
                                                                   r.CheckIn < model.CheckOut &&
                                                                   r.CheckOut > model.CheckIn);
                if (isOverlapping)
                {
                    ModelState.AddModelError("", "This property is already reserved for the selected dates.");
                    return View(model);
                }

                // Create Reservation
                var reservation = new Reservation
                {
                    AppUsers = customer,
                    Properties = property,
                    CheckIn = model.CheckIn,
                    CheckOut = model.CheckOut,
                    NumOfGuests = model.NumOfGuests,
                    WeekdayPrice = property.WeekdayPrice,
                    WeekendPrice = property.WeekendPrice,
                    CleaningFee = property.CleaningFee,
                    DiscountRate = model.DiscountRate / 100, // Convert to decimal for calculation
                    ReservationStatus = true, // Active and confirmed
                    City = property.City,
                    State = property.State
                };

                // Calculate Total Amount
                var TotalAmount = reservation.CalculateTotalAmount();

                // Save to Database
                _context.Reservations.Add(reservation);
                await _context.SaveChangesAsync();

                TempData["Message"] = $"Reservation successfully created for {customer.FirstName} {customer.LastName}.";
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
