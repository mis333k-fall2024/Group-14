using Files.DAL;
using Files.Models;
using Files.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Files.Seeding
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
                await SeedRoles.AddAllRoles(_roleManager);
            }
            catch (Exception ex)
            {
                // Add the error messages to a list of strings
                List<string> errorList = new List<string>
                {
                    ex.Message,
                    ex.InnerException?.Message
                };

                // Add additional inner exception messages if there are any
                if (ex.InnerException?.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            // This is the happy path - seeding worked!
            return View("Confirm");
        }

        public async Task<IActionResult> SeedUsers()
        {
            try
            {
                // Call the method to seed the users
                await SeedUsers.SeedAllUsers(_userManager, _context);
            }
            catch (Exception ex)
            {
                // Add the error messages to a list of strings
                List<string> errorList = new List<string>
                {
                    ex.Message,
                    ex.InnerException?.Message
                };

                // Add additional inner exception messages if there are any
                if (ex.InnerException?.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            // This is the happy path - seeding worked!
            return View("Confirm");
        }

        public IActionResult SeedCategories()
        {
            try
            {
                // Call the method to seed categories
                SeedCategories.SeedAllCategories(_context);
            }
            catch (Exception ex)
            {
                // Add the error messages to a list of strings
                List<string> errorList = new List<string>
                {
                    ex.Message,
                    ex.InnerException?.Message
                };

                // Add additional inner exception messages if there are any
                if (ex.InnerException?.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            // This is the happy path - seeding worked!
            return View("Confirm");
        }

        public IActionResult SeedProperties()
        {
            try
            {
                // Call the method to seed properties
                SeedProperties.SeedAllProperties(_context);
            }
            catch (Exception ex)
            {
                // Add the error messages to a list of strings
                List<string> errorList = new List<string>
                {
                    ex.Message,
                    ex.InnerException?.Message
                };

                // Add additional inner exception messages if there are any
                if (ex.InnerException?.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            // This is the happy path - seeding worked!
            return View("Confirm");
        }

        public IActionResult SeedReservations()
        {
            try
            {
                // Call the method to seed reservations
                SeedReservations.SeedAllReservations(_context);
            }
            catch (Exception ex)
            {
                // Add the error messages to a list of strings
                List<string> errorList = new List<string>
                {
                    ex.Message,
                    ex.InnerException?.Message
                };

                // Add additional inner exception messages if there are any
                if (ex.InnerException?.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            // This is the happy path - seeding worked!
            return View("Confirm");
        }

        public IActionResult SeedReviews()
        {
            try
            {
                // Call the method to seed reviews
                SeedReviews.SeedAllReviews(_context);
            }
            catch (Exception ex)
            {
                // Add the error messages to a list of strings
                List<string> errorList = new List<string>
                {
                    ex.Message,
                    ex.InnerException?.Message
                };

                // Add additional inner exception messages if there are any
                if (ex.InnerException?.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            // This is the happy path - seeding worked!
            return View("Confirm");
        }
    }
}
