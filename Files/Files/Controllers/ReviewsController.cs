using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Files.DAL;
using Files.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Files.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly AppDbContext _context;

        public ReviewsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reviews
        public async Task<IActionResult> Index(int propertyId)
        {
            // Retrieve the property details for display purposes
            var property = await _context.Properties
                .FirstOrDefaultAsync(p => p.PropertyID == propertyId);

            if (property == null)
            {
                // Return a NotFound view or an error message if the property is not found
                return NotFound("Property not found");
            }

            // Retrieve reviews for the specific property
            var reviews = await _context.Reviews
                .Include(r => r.AppUsers) // Eager load AppUsers
                .Where(r => r.Properties.PropertyID == propertyId) // Use PropertyID directly
                .ToListAsync();

            // Pass the necessary data to the view using ViewModel or ViewData
            ViewData["PropertyId"] = property.PropertyID;
            ViewData["PropertyName"] = $"{property.Street}, {property.City}";

            return View(reviews);
        }

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .Include(r => r.AppUsers) // Eager load AppUsers
                .Include(r => r.Properties) // Include navigation property
                .FirstOrDefaultAsync(m => m.ReviewID == id);

            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // GET: Reviews/Create
        [Authorize]
        public IActionResult Create(int propertyId)
        {
            // Fetch the property
            var property = _context.Properties.FirstOrDefault(p => p.PropertyID == propertyId);
            if (property == null)
            {
                return NotFound("Property not found.");
            }

            // Populate ViewBag with property details
            ViewBag.PropertyId = property.PropertyID;
            ViewBag.PropertyName = $"{property.Street}, {property.City}";

            return View();
        }

        // POST: Reviews/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(Review review, int propertyId)
        {
            // Retrieve the property based on propertyId
            var property = await _context.Properties.FirstOrDefaultAsync(p => p.PropertyID == propertyId);
            if (property == null)
            {
                return NotFound("Property not found.");
            }

            // Assign the property navigation property
            review.Properties = property;

            // Retrieve the logged-in user
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("User not logged in.");
            }

            // Fetch the user object from the database
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            // Assign the user navigation property
            review.AppUsers = user;

            // Validate the model state
            if (!ModelState.IsValid)
            {
                //error message
                TempData["SuccessMessage"] = "Property successfully created and is pending approval.";
                // Re-populate ViewBag with property details for validation errors
                ViewBag.PropertyId = property.PropertyID;
                ViewBag.PropertyName = $"{property.Street}, {property.City}";
                return View(review);
            }

            // Debugging: Log the ReviewID before saving (it should be 0 at this point)
            Console.WriteLine($"Before SaveChanges: ReviewID = {review.ReviewID}");

            // Save the review
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();

            // Debugging: Log the ReviewID after saving (it should now have a non-zero value)
            Console.WriteLine($"After SaveChanges: ReviewID = {review.ReviewID}");

            return RedirectToAction("Index", new { propertyId = property.PropertyID });
        }


        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .Include(r => r.Properties) // Include navigation property
                .FirstOrDefaultAsync(r => r.ReviewID == id);

            if (review == null)
            {
                return NotFound();
            }

            // Pass the associated property to the view
            ViewData["Properties"] = review.Properties;
            return View(review);
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewID,Rating,TextReview,HostComments,DisputeStatus")] Review review)
        {
            if (id != review.ReviewID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Associate the review with its property
                    var property = await _context.Properties.FirstOrDefaultAsync(p => p.PropertyID == review.Properties.PropertyID);

                    if (property == null)
                    {
                        return NotFound();
                    }

                    review.Properties = property;

                    _context.Update(review);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.ReviewID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                // Redirect to the property's review index page
                return RedirectToAction("Index", new { propertyId = review.Properties.PropertyID });
            }

            ViewData["Properties"] = review.Properties;
            return View(review);
        }

        // GET: Reviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .Include(r => r.Properties) // Include navigation property
                .FirstOrDefaultAsync(r => r.ReviewID == id);

            if (review == null)
            {
                return NotFound();
            }

            ViewData["Properties"] = review.Properties;
            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var review = await _context.Reviews
                .Include(r => r.Properties) // Include navigation property
                .FirstOrDefaultAsync(r => r.ReviewID == id);

            if (review != null)
            {
                _context.Reviews.Remove(review);
                await _context.SaveChangesAsync();

                // Redirect to the property's review index page
                return RedirectToAction("Index", new { propertyId = review.Properties.PropertyID });
            }

            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(int id)
        {
            return _context.Reviews.Any(e => e.ReviewID == id);
        }
    }
}
