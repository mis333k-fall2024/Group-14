using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Files.DAL; // Your data access layer namespace
using Files.Models; // Your models namespace
using Files.Utilities;

namespace Files.Controllers
{
    [Authorize] // Ensure only logged-in users can access these actions unless specified
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

        // GET: Reservations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reservations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReservationID,CheckIn,CheckOut,NumOfGuests,WeekdayPrice,WeekendPrice,CleaningFee,DiscountRate,ReservationStatus,ConfirmationNumber,PropertyId,UserId")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reservation);
        }

        // GET: Reservations/Cart
        [AllowAnonymous] // Allow unauthenticated users to access the cart
        public IActionResult Cart()
        {
            // Retrieve the cart from the session or initialize a new one
            var reservations = HttpContext.Session.GetObjectFromJson<ReservationList>("Reservations") ?? new ReservationList();

            // Pass the cart (reservations) to the view
            return View(reservations);
        }

        // GET: Reservations/Checkout
        public async Task<IActionResult> Checkout()
        {
            // Get the logged-in user's ID
            var userId = User.Identity.Name;

            // Retrieve all pending reservations for the user
            var reservations = await _context.Reservations
                .Where(r => r.UserId == userId && r.ReservationStatus == false) // Assuming false = "Pending"
                .ToListAsync();

            if (!reservations.Any())
            {
                TempData["Error"] = "Your cart is empty. Please add reservations before checking out.";
                return RedirectToAction("Index", "Home");
            }

            // Pass the reservations to the Checkout view
            return View(reservations);
        }

        // POST: Reservations/Confirm
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Confirm()
        {
            var userId = User.Identity.Name;

            // Get all pending reservations for the user
            var reservations = await _context.Reservations
                .Where(r => r.UserId == userId && r.ReservationStatus == false)
                .ToListAsync();

            if (!reservations.Any())
            {
                TempData["Error"] = "Your cart is empty. Please add reservations before confirming.";
                return RedirectToAction("Index", "Home");
            }

            // Mark all reservations as confirmed
            foreach (var reservation in reservations)
            {
                reservation.ReservationStatus = true;
            }

            await _context.SaveChangesAsync();

            // Redirect to a thank-you page or the home page
            TempData["Message"] = "Your reservations have been confirmed!";
            return RedirectToAction("ThankYou");
        }

        // GET: Reservations/ThankYou
        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
