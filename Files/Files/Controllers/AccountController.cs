using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Files.Models;
using Files.DAL;
using Files.Utilities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Files.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;

        public AccountController(AppDbContext appDbContext, UserManager<AppUser> userManager, SignInManager<AppUser> signIn)
        {
            _context = appDbContext;
            _userManager = userManager;
            _signInManager = signIn;
        }

        // GET: /Account/Register
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel rvm)
        {
            if (!ModelState.IsValid) return View(rvm);

            // Check age requirement
            if ((DateTime.Now - rvm.DOB).TotalDays / 365 < 18)
            {
                ModelState.AddModelError("DOB", "You must be at least 18 years old to create an account.");
                return View(rvm);
            }

            var newUser = new AppUser
            {
                UserName = rvm.Email,
                Email = rvm.Email,
                PhoneNumber = rvm.PhoneNumber,
                FirstName = rvm.FirstName,
                LastName = rvm.LastName,
                Address = rvm.Address,
                DOB = rvm.DOB,
                Status = rvm.Status
            };

            var aum = new AddUserModel
            {
                User = newUser,
                Password = rvm.Password,
                RoleName = "Customer"
            };

            var result = await Utilities.AddUser.AddUserWithRoleAsync(aum, _userManager, _context);

            if (result.Succeeded)
            {
                await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, false, false);
                return RedirectToAction("Index", "Home");
            }

            foreach (var error in result.Errors) ModelState.AddModelError("", error.Description);
            return View(rvm);
        }

        // GET: /Account/Login
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            if (User.Identity.IsAuthenticated) return View("Error", new string[] { "Access Denied" });

            _signInManager.SignOutAsync(); // Remove old cookies
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel lvm, string? returnUrl)
        {
            if (!ModelState.IsValid) return View(lvm);

            var result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, lvm.RememberMe, false);

            if (result.Succeeded) return Redirect(returnUrl ?? "/");

            ModelState.AddModelError("", "Invalid login attempt.");
            return View(lvm);
        }

        // GET: /Account/ModifyProfile
        [Authorize(Roles = "Admin, Host, Customer")]
        public async Task<ActionResult> ModifyProfile(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            var model = new ModifyProfileViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                Address = user.Address,
                DOB = user.DOB
            };

            return View(model);
        }

        // POST: /Account/ModifyProfile
        [HttpPost]
        [Authorize(Roles = "Admin, Host, Customer")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ModifyProfile(string id, ModifyProfileViewModel model)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            if (!ModelState.IsValid) return View(model);

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.PhoneNumber = model.PhoneNumber;
            user.Address = model.Address;
            user.DOB = model.DOB;

            if (!string.IsNullOrEmpty(model.NewPassword))
            {
                if (!User.IsInRole("Admin") && string.IsNullOrEmpty(model.OldPassword))
                {
                    ModelState.AddModelError("OldPassword", "Current password is required to change your password.");
                    return View(model);
                }

                var passwordResult = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

                if (!passwordResult.Succeeded)
                {
                    foreach (var error in passwordResult.Errors) ModelState.AddModelError("", error.Description);
                    return View(model);
                }
            }

            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                foreach (var error in updateResult.Errors) ModelState.AddModelError("", error.Description);
            }

            return RedirectToAction("Index");
        }

        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogOff()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
