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
        [Authorize]
        public async Task<IActionResult> Index()
        {
            List<Reservation> reservations;

            if (User.IsInRole("Admin"))
            {
                // Retrieve all reservations for properties hosted by the logged-in user (Host role)
                string hostId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                // Admin can view all reservations
                reservations = await _context.Reservations
                    .Include(r => r.Properties) // Include property details
                    .Include(r => r.AppUsers)  // Include user details
                    .ToListAsync();
            }
            else if (User.IsInRole("Customer"))
            {
                // Retrieve reservations for the logged-in customer
                string customerId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                reservations = await _context.Reservations
                    .Include(r => r.Properties) // Include property details
                    .Include(r => r.AppUsers)  // Include user details
                    .Where(r => r.AppUsers.Id == customerId) // Filter by logged-in user ID
                    .ToListAsync();
            }
            else
            {
                return Forbid(); // Forbid access for other roles
            }

            // Separate reservations into categories based on their status
            var pastReservations = reservations.Where(r => r.CheckOut < DateTime.Now).ToList();
            var futureReservations = reservations.Where(r => r.CheckIn > DateTime.Now && r.ReservationStatus).ToList();
            var canceledReservations = reservations.Where(r => !r.ReservationStatus).ToList();

            // Pass categorized reservations to the view using a ViewModel
            var model = new ReservationHistoryViewModel
            {
                PastReservations = pastReservations,
                FutureReservations = futureReservations,
                CanceledReservations = canceledReservations
            };

            return View(model);
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
        [Authorize(Roles = "Customer")]
        public IActionResult Cart()
        {
            var reservations = HttpContext.Session.GetObjectFromJson<ReservationList>("Reservations") ?? new ReservationList();
            return View(reservations);
        }
        // GET: Reservations/UserReservations
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> UserReservations()
        {
            // Retrieve the logged-in user's ID
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
            {
                TempData["Error"] = "You must be logged in to view your reservations.";
                return RedirectToAction("Index", "Home");
            }

            // Fetch reservations for the logged-in user
            var userReservations = await _context.Reservations
                .Include(r => r.Properties) // Include property details
                .Where(r => r.AppUsers.Id == userId) // Filter by user ID
                .ToListAsync();

            if (!userReservations.Any())
            {
                TempData["Message"] = "You have no reservations.";
                return RedirectToAction("Cart"); // Redirect to cart if no reservations
            }

            return View(userReservations); // Pass reservations to the view
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

        // Add this new method for assigning a user to a reservation
        public async Task<IActionResult> AssignUserToReservation(string userId, int reservationId, int propertyId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return View("Error", new string[] { "Please specify a user to assign to the reservation." });
            }

            // Find the reservation in the database
            var dbReservation = await _context.Reservations
                .Include(r => r.AppUsers) // Include the user
                .FirstOrDefaultAsync(r => r.ReservationID == reservationId);

            if (dbReservation == null)
            {
                return View("Error", new string[] { "Reservation not found." });
            }

            // Find the user in the database
            var appUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (appUser == null)
            {
                return View("Error", new string[] { "User not found." });
            }

            // Assign the user to the reservation
            dbReservation.AppUsers = appUser;

            // Find the property in the database
            var dbProperty = await _context.Properties.FirstOrDefaultAsync(p => p.PropertyID == propertyId);

            if (dbProperty == null)
            {
                return View("Error", new string[] { "Property not found." });
            }

            dbReservation.Properties = dbProperty;

            // Update the reservation in the database
            _context.Update(dbReservation);
            await _context.SaveChangesAsync();

            // Redirect to a relevant page (e.g., reservation details)
            return RedirectToAction("Details", new { id = dbReservation.ReservationID });
        }


        // POST: Reservations/AddToCart
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

            // Load or create the reservation list from session
            var reservationList = HttpContext.Session.GetObjectFromJson<ReservationList>("Reservations") ?? new ReservationList();

            // Check for overlapping dates for this property
            if (_context.Reservations.Any(r => r.Properties.PropertyID == propertyId &&
                                               ((checkIn < r.CheckOut && checkOut > r.CheckIn))))
            {
                TempData["Error"] = "This property is already booked for the selected dates.";
                return RedirectToAction("Details", "Properties", new { id = propertyId });
            }

            // Check for overlapping dates in the cart
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
                Properties = property,
                City = property.City,
                State = property.State,
            };

            // Apply discount logic
            int totalDays = (checkOut - checkIn).Days;
            if (totalDays >= property.DiscountMinStay)
            {
                reservation.DiscountRate = property.DiscountRate ?? 0m;
                reservation.DiscountAmount = reservation.CalculatePreDiscountPrice() * reservation.DiscountRate; // Calculate the discount amount
            }
            else
            {
                reservation.DiscountRate = 0m; // No discount
                reservation.DiscountAmount = 0m;
            }

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
                Subtotal = reservationList.Reservations.Sum(r => r.CalculateStayPrice() + r.CleaningFee),
                Tax = reservationList.Reservations.Sum(r => r.CalculateStayPrice() + r.CleaningFee) * Reservation.TaxRate,
                GrandTotal = reservationList.Reservations.Sum(r => r.CalculateStayPrice() + r.CleaningFee) * (1 + Reservation.TaxRate),
                TransactionDate = DateTime.Now
            };

            return View(transaction);
        }

        // GET: Reservations/CheckAvailability
        [HttpGet]
        [AllowAnonymous]
        public JsonResult CheckAvailability(int propertyId, DateTime checkIn, DateTime checkOut)
        {
            var overlappingReservations = _context.Reservations.Any(r =>
                r.Properties.PropertyID == propertyId &&
                (checkIn < r.CheckOut && checkOut > r.CheckIn));

            if (overlappingReservations)
            {
                return Json(new { isAvailable = false, message = "This property is already booked for the selected dates." });
            }

            return Json(new { isAvailable = true });
        }

        //post;Confirm
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Confirm()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
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
                Tax = reservationList.TotalPrice * Reservation.TaxRate,
                GrandTotal = reservationList.TotalPrice + (reservationList.TotalPrice * Reservation.TaxRate),
                UserId = userId
            };

            try
            {
                // Retrieve the logged-in user
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
                if (user == null)
                {
                    return NotFound("User not found.");
                }

                foreach (var reservation in reservationList.Reservations)
                {
                    var property = await _context.Properties.FirstOrDefaultAsync(p => p.PropertyID == reservation.Properties.PropertyID);

                    if (property == null)
                    {
                        return NotFound($"Property with ID {reservation.Properties.PropertyID} not found.");
                    }

                    // Assign the logged-in user to the reservation
                    reservation.AppUsers = user;

                    // Assign the next confirmation number using the utility
                    reservation.ConfirmationNumber = GenerateNextConfirmationNumber.GetNextConfirmationNumber(_context);
                    reservation.ReservationStatus = true;
                    reservation.Properties = property;

                    transaction.Reservations.Add(reservation);
                    _context.Reservations.Add(reservation);
                }

                _context.Transactions.Add(transaction);
                await _context.SaveChangesAsync();
            }
            finally
            {
                HttpContext.Session.Remove("Reservations");
            }

            TempData["Message"] = "Your reservations have been confirmed!";
            return RedirectToAction("ThankYou", new { confirmationNumber = reservationList.Reservations.FirstOrDefault()?.ConfirmationNumber });
        }


        // GET: Reservations/ThankYou
        public IActionResult ThankYou(int confirmationNumber)
        {
            if (confirmationNumber == 0)
            {
                return BadRequest("Confirmation number is required.");
            }

            var reservation = _context.Reservations.FirstOrDefault(r => r.ConfirmationNumber == confirmationNumber);

            if (reservation == null)
            {
                return NotFound("Reservation with this confirmation number not found.");
            }

            ViewBag.ConfirmationNumber = confirmationNumber;
            return View();
        }

        // Cancel reservation
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cancel(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);

            if (reservation == null)
            {
                return NotFound("Reservation not found.");
            }

            // Check if the reservation is eligible for cancellation
            var currentDateTime = DateTime.Now;
            var cancellationDeadline = reservation.CheckIn.AddDays(-1).Date; // Day before CheckIn at 12:00am
            if (currentDateTime >= cancellationDeadline)
            {
                TempData["Error"] = "You cannot cancel reservations within 1 day of the check-in date.";
                return RedirectToAction(nameof(Index));
            }
            if (reservation.CheckIn <= currentDateTime)
            {
                TempData["Error"] = "You cannot cancel reservations for check-in dates that have already passed.";
                return RedirectToAction(nameof(Index));
            }

            // Mark the reservation as canceled
            reservation.ReservationStatus = false; // Mark as canceled
            await _context.SaveChangesAsync();
            TempData["Message"] = "Reservation canceled successfully.";
            return RedirectToAction(nameof(Index));
        }




        // --- Admin Functionality to Make Reservations for Customers ---

        // GET: Reservations/MakeReservation
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult MakeReservation()
        {
            var model = new MakeReservationViewModel
            {
                Customers = _context.Users.ToList(),
                Properties = _context.Properties.ToList()
            };

            return View(model);
        }

        // POST: Reservations/MakeReservation
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> MakeReservation(MakeReservationViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Fetch customer and property from the database
                var customer = await _context.Users.FirstOrDefaultAsync(u => u.Id == model.CustomerId);
                var property = await _context.Properties.FirstOrDefaultAsync(p => p.PropertyID == model.PropertyId);

                if (customer == null || property == null)
                {
                    ModelState.AddModelError("", "Invalid customer or property selection.");
                    model.Customers = _context.Users.ToList();
                    model.Properties = _context.Properties.ToList();
                    return View(model);
                }

                // Check for overlapping reservations
                var isOverlapping = _context.Reservations.Any(r => r.Properties.PropertyID == model.PropertyId &&
                                                                   r.CheckIn < model.CheckOut &&
                                                                   r.CheckOut > model.CheckIn);
                if (isOverlapping)
                {
                    ModelState.AddModelError("", "This property is already reserved for the selected dates.");
                    model.Customers = _context.Users.ToList();
                    model.Properties = _context.Properties.ToList();
                    return View(model);
                }

                // Create reservation
                var reservation = new Reservation
                {
                    AppUsers = customer,
                    Properties = property,
                    CheckIn = model.CheckIn,
                    CheckOut = model.CheckOut,
                    NumOfGuests = property.GuestsAllowed,
                    WeekdayPrice = property.WeekdayPrice,
                    WeekendPrice = property.WeekendPrice,
                    CleaningFee = property.CleaningFee,
                    DiscountRate = property.DiscountRate ?? 0m,
                    ReservationStatus = true
                };

                // Calculate total amount (method from Reservation model)
                reservation.CalculateTotalAmount();

                // Add reservation to the database
                _context.Reservations.Add(reservation);
                await _context.SaveChangesAsync();

                TempData["Message"] = $"Reservation created for {customer.FirstName} {customer.LastName}.";
                return RedirectToAction("Index");
            }

            model.Customers = _context.Users.ToList();
            model.Properties = _context.Properties.ToList();
            return View(model);
        }
    }
}

        