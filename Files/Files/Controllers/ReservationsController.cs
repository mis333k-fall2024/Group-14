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
                DiscountRate = property.DiscountRate ?? throw new InvalidOperationException("Discount rate cannot be null."),
                Properties = property
            };

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
                .Where(r => r.AppUsers.UserName == userId && r.ReservationStatus == false)
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
    }
}
