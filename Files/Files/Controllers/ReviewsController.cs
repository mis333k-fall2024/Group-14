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
            //var reviews = await _context.Reviews
            //.Include(r => r.AppUsers) // Eager load AppUsers
            //.Where(r => r.Properties.PropertyID == propertyId) // Use PropertyID directly
            //.ToListAsync();
            //review (admin/host only)
            // Define the base query for retrieving reviews
            IQueryable<Review> reviewsQuery = _context.Reviews
                .Include(r => r.AppUsers) // Eager load AppUsers
                .Where(r => r.Properties.PropertyID == propertyId); // Filter by PropertyID

            // Apply additional filtering if the user is not an Admin or Host
            if (!User.IsInRole("Admin") && !User.IsInRole("Host"))
            {
                reviewsQuery = reviewsQuery.Where(r => r.DisputeStatus == StatusDispute.NoDispute || r.DisputeStatus == StatusDispute.InvalidDispute);
            }

            // Execute the query to get the filtered or unfiltered reviews
            var reviews = await reviewsQuery.ToListAsync();
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

            // Calculate the average guest rating for the property
            var property = await _context.Properties
                .Include(p => p.Reviews) // Include the Reviews navigation property
                .FirstOrDefaultAsync(p => p.PropertyID == review.Properties.PropertyID);

            if (property == null)
            {
                return NotFound("Property not found.");
            }

            var averageRating = property.Reviews
                .Where(r => r.DisputeStatus != StatusDispute.ValidDispute && r.DisputeStatus != StatusDispute.Disputed)
                .Any()
                ? (decimal?)property.Reviews
                    .Where(r => r.DisputeStatus != StatusDispute.ValidDispute && r.DisputeStatus != StatusDispute.Disputed)
                    .Average(r => r.Rating)
                : null;

            ViewData["AverageRating"] = averageRating;
            ViewData["PropertyName"] = $"{property.Street}, {property.City}";

            return View(review);
        }

        // GET: Reviews/Create
        [Authorize(Roles = "Customer")]
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
        [Authorize(Roles = "Customer")]
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

        //dispute for hosts
        [HttpPost]
        [Authorize(Roles = "Host")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MarkAsDisputed(int id)
        {
            // Find the review by ID
            var review = await _context.Reviews
        .Include(r => r.Properties) // Include navigation property
        .FirstOrDefaultAsync(r => r.ReviewID == id);

            if (review == null)
            {
                // Log the error and return a NotFound response
                Console.WriteLine($"Review with ID {id} not found.");
                return NotFound("Review not found.");
            }

            // Only allow changing status if the current status is NoDispute
            if (review.DisputeStatus == StatusDispute.NoDispute)
            {
                // Update the dispute status to Disputed
                review.DisputeStatus = StatusDispute.Disputed;

                try
                {
                    _context.Update(review); // Update the review in the context
                    await _context.SaveChangesAsync(); // Save changes to the database

                    // Log success for debugging purposes
                    Console.WriteLine($"Review ID {id} status updated to Disputed.");
                }
                catch (Exception ex)
                {
                    // Log any errors that occur during the update
                    Console.WriteLine($"Error updating review ID {id}: {ex.Message}");
                    return StatusCode(500, "An error occurred while updating the review status.");
                }
            }
            else
            {
                // Log that the review is not eligible for a status update
                Console.WriteLine($"Review ID {id} has status {review.DisputeStatus} and cannot be updated to Disputed.");
                return BadRequest("The review is not eligible for a dispute.");
            }

            // Redirect back to the reviews index or details page
            return RedirectToAction(nameof(Index), new { propertyId = review.Properties.PropertyID });
        }

        //dispute approval for admin
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MarkAsValidDispute(int id)
        {
            // Find the review by ID
            var review = await _context.Reviews.FirstOrDefaultAsync(r => r.ReviewID == id);

            if (review == null)
            {
                return NotFound();
            }

            // Only allow changing status if the current status is Disputed
            if (review.DisputeStatus == StatusDispute.Disputed)
            {
                review.DisputeStatus = StatusDispute.ValidDispute;
                _context.Update(review);
                await _context.SaveChangesAsync();
            }

            // Redirect back to the reviews index or details page
            return RedirectToAction(nameof(Index), new { propertyId = review.Properties.PropertyID });
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MarkAsInvalidDispute(int id)
        {
            // Find the review by ID
            var review = await _context.Reviews.FirstOrDefaultAsync(r => r.ReviewID == id);

            if (review == null)
            {
                return NotFound();
            }

            // Only allow changing status if the current status is Disputed
            if (review.DisputeStatus == StatusDispute.Disputed)
            {
                review.DisputeStatus = StatusDispute.InvalidDispute;
                _context.Update(review);
                await _context.SaveChangesAsync();
            }

            // Redirect back to the reviews index or details page
            return RedirectToAction(nameof(Index), new { propertyId = review.Properties.PropertyID });
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

        //code for to HostDisput
        [Authorize(Roles = "Host")]
        public async Task<IActionResult> HostDispute(int propertyId)
        {
            // Retrieve the property details
            var property = await _context.Properties
                .Include(p => p.Reviews) // Include the associated reviews
                .FirstOrDefaultAsync(p => p.PropertyID == propertyId);

            if (property == null)
            {
                return NotFound("Property not found.");
            }

            // Filter reviews that are eligible to be disputed (status is NoDispute)
            var reviewsToDispute = property.Reviews
                .Where(r => r.DisputeStatus == StatusDispute.NoDispute)
                .ToList();

            // Pass data to the view
            ViewData["PropertyId"] = propertyId;
            ViewData["PropertyName"] = $"{property.Street}, {property.City}";

            return View(reviewsToDispute);
        }

        //code for to Admin
    }

}
