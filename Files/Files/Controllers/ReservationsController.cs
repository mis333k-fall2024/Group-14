using System;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
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
            return View(await _context.Reservations.ToListAsync());
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
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
            if (checkIn < DateTime.Today)
            {
                TempData["Error"] = "Check-in date cannot be in the past.";
                return RedirectToAction("Cart");
            }

            if (checkOut <= checkIn)
            {
                TempData["Error"] = "Check-out date must be after the check-in date.";
                return RedirectToAction("Cart");
            }

            var reservationList = HttpContext.Session.GetObjectFromJson<ReservationList>("Reservations") ?? new ReservationList();

            var property = _context.Properties.FirstOrDefault(p => p.PropertyID == propertyId);
            if (property == null)
            {
                return NotFound("Property not found.");
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
                Properties = property,
                City = property.City,
                State = property.State,
            };

            reservationList.Reservations.Add(reservation);
            HttpContext.Session.SetObjectAsJson("Reservations", reservationList);

            return RedirectToAction("Cart");
        }

        // GET: Reservations/Transaction
        public IActionResult Transaction()
        {
            var reservationList = HttpContext.Session.GetObjectFromJson<ReservationList>("Reservations");

            if (reservationList == null || !reservationList.Reservations.Any())
            {
                TempData["Error"] = "Your cart is empty. Please add reservations before checking out.";
                return RedirectToAction("Cart");
            }

            var transaction = new Transaction
            {
                Reservations = reservationList.Reservations,
                Subtotal = reservationList.TotalPrice,
                Tax = reservationList.TotalPrice * 0.1m, // 10% tax
                GrandTotal = reservationList.TotalPrice + (reservationList.TotalPrice * 0.1m),
                TransactionDate = DateTime.Now
            };

            return View(transaction);
        }

        // POST: Reservations/Confirm
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Confirm()
        {
            var userId = User.FindFirstValue(System.Security.Claims.ClaimTypes.NameIdentifier);

            var reservationList = HttpContext.Session.GetObjectFromJson<ReservationList>("Reservations");

            if (reservationList == null || !reservationList.Reservations.Any())
            {
                TempData["Error"] = "Your cart is empty.";
                return RedirectToAction("Cart");
            }

            var transaction = new Transaction
            {
                ConfirmationNumber = Guid.NewGuid().ToString(),
                TransactionDate = DateTime.Now,
                Subtotal = reservationList.TotalPrice,
                Tax = reservationList.TotalPrice * 0.1m,
                GrandTotal = reservationList.TotalPrice + (reservationList.TotalPrice * 0.1m),
                UserId = userId
            };

            try
            {
                // Enable IDENTITY_INSERT for the Properties table
                _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Properties ON");

                // Add reservations to the transaction
                foreach (var reservation in reservationList.Reservations)
                {
                    var property = await _context.Properties.FirstOrDefaultAsync(p => p.PropertyID == reservation.Properties.PropertyID);

                    if (property == null)
                    {
                        return NotFound($"Property with ID {reservation.Properties.PropertyID} not found.");
                    }

                    reservation.ReservationStatus = true;
                    reservation.Properties = property;
                    transaction.Reservations.Add(reservation); // Link reservations to the transaction
                    _context.Reservations.Add(reservation);    // Add each reservation to the database
                }

                _context.Transactions.Add(transaction);

                await _context.SaveChangesAsync();
            }
            finally
            {
                // Disable IDENTITY_INSERT for the Properties table
                _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Properties OFF");
            }

            HttpContext.Session.Remove("Reservations");

            TempData["Message"] = "Your reservations have been confirmed!";
            return RedirectToAction("ThankYou", new { confirmationNumber = transaction.ConfirmationNumber });
        }

        // GET: Reservations/ThankYou
        public IActionResult ThankYou(string confirmationNumber)
        {
            return View((object)confirmationNumber);
        }
    }
}
