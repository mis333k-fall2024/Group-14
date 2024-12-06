using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Files.DAL;
using Files.Models;
using Files.Views;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Files.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly AppDbContext _context;

        public PropertiesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Properties
        public async Task<IActionResult> Index()
        {
            var approvedProperties = await _context.Properties
            .Where(p => p.PropertyStatus)
            // Using propstat from Property 
            .ToListAsync();
                        return View(approvedProperties);

        }

        // GET: Properties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Properties
                .FirstOrDefaultAsync(m => m.PropertyID == id);
            if (@property == null)
            {
                return NotFound();
            }

            return View(@property);
        }

  

        // GET: Properties/Create
        public IActionResult Create()
        {
            return View();
        }
        
            // POST: Properties/Create
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PropertyID,PropertyNumber,Street,City,State,Zip,Bedrooms,Bathrooms,GuestsAllowed,PetsAllowed,FreeParking,WeekdayPrice,WeekendPrice,CleaningFee,DiscountRate,DiscountMinStay,UnavailableDates,PropertyStatus,CategoryID")] Property @property)
        {
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
            property.AppUsers = user;

            if (ModelState.IsValid)
            {
                //mapping viewmodel to model

                property.PropertyStatus = false; //makes pending approval

                //add the new prop
                _context.Add(@property);
                await _context.SaveChangesAsync();
                //sucesss message
                TempData["SuccessMessage"] = "Property successfully created and is pending approval.";
                ViewBag.ApprovalStatus = "Your property is now pending approval.";
                //return to index
                return RedirectToAction(nameof(Index));

            }

            //trying to have error pg
            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine(error.ErrorMessage);  // Log or display these errors
            }
            return View(@property);
        }

        // GET: Properties/Edit/
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Properties.FindAsync(id);
            if (@property == null)
            {
                return NotFound();
            }
            ViewBag.ApprovalStatus = property.PropertyStatus ? "Approved" : "Pending approval";
            return View(@property);
        }

        // POST: Properties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, bool PropertyStatus)
        {
            var property = await _context.Properties.FindAsync(id);
            if (property == null)
            {
                return NotFound();
            }
            // Update the approval status of the property 
            property.PropertyStatus = PropertyStatus;
            _context.Update(property);
            await _context.SaveChangesAsync();
            // Set the approval status message based on whether it was approved or rejected
            ViewBag.ApprovalStatus = PropertyStatus ? "Approved" : "Rejected";
            return RedirectToAction(nameof(PendingApproval)); }

        // GET: Properties/PendingApproval (For admins to see properties awaiting approval)
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PendingApproval()
        {
            // Get all properties that are pending approval (Propertystatus/approved = false)
            var pendingProperties = await _context.Properties
                .Where(p => !p.PropertyStatus) // Only show properties not approved yet
                .ToListAsync();
            return View(pendingProperties);
        }


            // GET: Properties/Delete/5
            public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Properties
                .FirstOrDefaultAsync(m => m.PropertyID == id);
            if (@property == null)
            {
                return NotFound();
            }

            return View(@property);
        }

        // POST: Properties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @property = await _context.Properties.FindAsync(id);
            if (@property != null)
            {
                _context.Properties.Remove(@property);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropertyExists(int id)
        {
            return _context.Properties.Any(e => e.PropertyID == id);
        }
    }
}
