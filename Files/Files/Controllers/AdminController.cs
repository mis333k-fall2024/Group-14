using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Files.DAL;
using Files.Models;

namespace Files.Controllers
{
    [Authorize(Roles = "Admin")]  // Ensure only Admins can access these actions
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public AdminController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // 1. Hire New Admin (Create Admin Profile)
        [HttpGet]
        public IActionResult HireAdmin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HireAdmin(HireAdminViewModel model)
        {
            if (ModelState.IsValid)
            {
                var DOB = model.DOB;
                 if ((DateTime.Now - model.DOB).TotalDays / 365 < 18
                {
                    ModelState.AddModelError("", "Admins must be at least 18 years old to create an account.");
                    return View(model);
                }

                var newAdmin = new AppUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    PhoneNumber = model.PhoneNumber,
                    DOB = model.DOB
                };

                var result = await _userManager.CreateAsync(newAdmin, model.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(newAdmin, "Admin");
                    return RedirectToAction("Index", "Admin");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        // 2. Fire Admin (Lock the Account)
        public async Task<IActionResult> FireAdmin(string adminId)
        {
            var admin = await _userManager.FindByIdAsync(adminId);
            if (admin == null || !await _userManager.IsInRoleAsync(admin, "Admin"))
            {
                return NotFound();
            }

            // Lock the admin account
            var result = await _userManager.SetLockoutEnabledAsync(admin, true);
            await _userManager.SetLockoutEndDateAsync(admin, DateTimeOffset.MaxValue);

            return RedirectToAction("Index", "Admin");
        }

        // 3. Rehire Admin (Unlock the Account)
        public async Task<IActionResult> RehireAdmin(string adminId)
        {
            var admin = await _userManager.FindByIdAsync(adminId);
            if (admin == null || !await _userManager.IsInRoleAsync(admin, "Admin"))
            {
                return NotFound();
            }

            // Unlock the admin account
            await _userManager.SetLockoutEndDateAsync(admin, DateTimeOffset.UtcNow);

            return RedirectToAction("Index", "Admin");
        }

        // 4. Modify Admin, Host, Customer Profiles (Update Profile Details)
        [HttpGet]
        public async Task<IActionResult> ModifyProfile(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            var model = new ModifyProfileViewModel
            {
                UserId = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                PhoneNumber = user.PhoneNumber,
                DOB = user.DOB
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModifyProfile(ModifyProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (user == null)
                {
                    return NotFound();
                }

                // Only allow modification of fields except email
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Address = model.Address;
                user.PhoneNumber = model.PhoneNumber;
                user.DOB = model.DOB;

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Admin");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        // 5. Reset Password (Without Previous Password)
        [HttpGet]
        public IActionResult ResetPassword(string userId)
        {
            var model = new ResetPasswordViewModel { UserId = userId };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (user == null)
                {
                    return NotFound();
                }

                var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
                var result = await _userManager.ResetPasswordAsync(user, resetToken, model.NewPassword);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Admin");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        // Index (Admin Dashboard)
        public IActionResult Index()
        {
            // Get list of all users (admin, host, customer)
            var users = _userManager.Users.ToList();
            return View(users);
        }
    }
}
