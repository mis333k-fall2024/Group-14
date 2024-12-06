using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Files.Models;
using Files.DAL;
using System.Threading.Tasks;

namespace Files.Controllers
{
    [Authorize]
    public class ModifyProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;

        public ModifyProfileController(UserManager<AppUser> userManager, AppDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: ModifyProfile/Index/{id}
        public async Task<IActionResult> Index(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            var model = new ModifyProfile
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                Address = user.Address,
                DOB = user.DOB,
                Email = user.Email // Email remains read-only
            };

            // Check if the user is an Admin
            if (User.IsInRole("Admin"))
            {
                return View("AdminModifyProfile", model); // Admin view
            }
            else
            {
                return View("UserModifyProfile", model);  // Host/Customer view
            }
        }

        // POST: ModifyProfile/SaveChanges
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveChanges(string id, ModifyProfile model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(id);
                if (user == null) return NotFound();

                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.PhoneNumber = model.PhoneNumber;
                user.Address = model.Address;
                user.DOB = model.DOB;

                // Handle password change logic (if required)
                if (!string.IsNullOrEmpty(model.NewPassword))
                {
                    if (string.IsNullOrEmpty(model.OldPassword))
                    {
                        ModelState.AddModelError("OldPassword", "Current password is required to change your password.");
                        return View("Index", model);
                    }

                    var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
                    if (!result.Succeeded)
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                        return View("Index", model);
                    }
                }

                var updateResult = await _userManager.UpdateAsync(user);
                if (updateResult.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in updateResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View("Index", model);
        }
    }
}
