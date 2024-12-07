// Include necessary using statements
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

        // GET: Reservations/Cart
        [Authorize(Roles = "Customer")]
        public IActionResult Cart()
        {
            var reservations = HttpContext.Session.GetObjectFromJson<ReservationList>("Reservations") ?? new ReservationList();
            return View(reservations);
        }

        // POST: Reservations/RemoveFromCart
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveFromCart(int reservationId)
        {
            // Get the reservation list from session
            var reservationList = HttpContext.Session.GetObjectFromJson<ReservationList>("Reservations") ?? new ReservationList();

            // Find the reservation to remove
            var reservationToRemove = reservationList.Reservations.FirstOrDefault(r => r.ReservationID == reservationId);
            if (reservationToRemove != null)
            {
                // Remove the reservation from the list
                reservationList.Reservations.Remove(reservationToRemove);

                // Update the session
                HttpContext.Session.SetObjectAsJson("Reservations", reservationList);

                TempData["Message"] = "Reservation removed successfully!";
            }
            else
            {
                TempData["Error"] = "Reservation not found.";
            }

            return RedirectToAction("Cart");
        }

        // Other existing methods (AddToCart, Confirm, etc.) remain unchanged...

        // Example for AddToCart (existing)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddToCart(int propertyId, DateTime checkIn, DateTime checkOut, int numOfGuests)
        {
            if (checkIn <= DateTime.Today)
            {
                TempData["Error"] = "Check-In date must be after today.";
                return RedirectToAction("Cart");
            }

            if (checkOut <= checkIn)
            {
                TempData["Error"] = "Check-out date must be after the check-in date.";
                return RedirectToAction("Cart");
            }

            var reservationList = HttpContext.Session.GetObjectFromJson<ReservationList>("Reservations") ?? new ReservationList();

            if (_context.Reservations.Any(r => r.Properties.PropertyID == propertyId &&
                                               ((checkIn < r.CheckOut && checkOut > r.CheckIn))))
            {
                TempData["Error"] = "This property is already booked for the selected dates.";
                return RedirectToAction("Details", "Properties", new { id = propertyId });
            }

            if (reservationList.Reservations.Any(r => checkIn < r.CheckOut && checkOut > r.CheckIn))
            {
                TempData["Error"] = "You cannot add reservations with overlapping dates.";
                return RedirectToAction("Cart");
            }

            var property = _context.Properties.FirstOrDefault(p => p.PropertyID == propertyId);
            if (property == null)
            {
                return NotFound("Property not found.");
            }

            var reservation = new Reservation
            {
                CheckIn = checkIn,
                CheckOut = checkOut,
                NumOfGuests = property.GuestsAllowed,
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

        // GET: Reservations/Transaction (existing)
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
    }
}
