using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Files.DAL;
using Files.Models;
using Files.Seeding;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Files.Controllers
{
    public class SeedController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedController(AppDbContext db, UserManager<AppUser> um, RoleManager<IdentityRole> rm)
        {
            _context = db;
            _userManager = um;
            _roleManager = rm;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SeedRoles()
        {
            try
            {
                // Call the method to seed the roles
                await Seeding.SeedRoles.AddAllRoles(_roleManager);
            }
            catch (Exception ex)
            {
                return HandleError(ex);
            }

            // Successful seeding
            return View("Confirm");
        }

        public async Task<IActionResult> SeedUsers()
        {
            try
            {
                // Call the method to seed the users
                await Seeding.SeedUsers.SeedAllUsers(_userManager, _context);
            }
            catch (Exception ex)
            {
                return HandleError(ex);
            }

            // Successful seeding
            return View("Confirm");
        }

        public IActionResult SeedProperties()
        {
            try
            {

                Seeding.SeedProperties.SeedAllProperties(_context);
            }
            catch (Exception ex)
            {
                return HandleError(ex);
            }

            // Successful seeding
            return View("Confirm");
        }

        public IActionResult SeedCategories()
        {
            try
            {
           
                Seeding.SeedCategories.SeedAllCategories(_context);
            }
            catch (Exception ex)
            {
                return HandleError(ex);
            }

            // Successful seeding
            return View("Confirm");
        }

        public IActionResult SeedReservations()
        {
            try
            {
                // Call the method to seed reservations
                Seeding.SeedReservations.SeedAllReservations(_context);
            }
            catch (Exception ex)
            {
                return HandleError(ex);
            }

            // Successful seeding
            return View("Confirm");
        }

        public IActionResult SeedReviews()
        {
            try
            {
                // Call the method to seed reviews
                Seeding.SeedReviews.SeedAllReviews(_context);
            }
            catch (Exception ex)
            {
                return HandleError(ex);
            }

            // Successful seeding
            return View("Confirm");
        }

        // Helper method for error handling
        private IActionResult HandleError(Exception ex)
        {
            var errorList = new List<string>
            {
                ex.Message
            };

            // Add inner exceptions if present
            if (ex.InnerException != null)
            {
                errorList.Add(ex.InnerException.Message);
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }
            }

            return View("Error", errorList);
        }
    }
}
