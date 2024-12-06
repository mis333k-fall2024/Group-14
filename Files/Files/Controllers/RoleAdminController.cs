using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Files.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Files.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleAdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleAdminController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: /RoleAdmin/
        public async Task<ActionResult> Index()
        {
            var roles = _roleManager.Roles.Select(role => new RoleEditModel
            {
                Role = role,
                RoleMembers = _userManager.Users.Where(user => _userManager.IsInRoleAsync(user, role.Name).Result).ToList(),
                RoleNonMembers = _userManager.Users.Where(user => !_userManager.IsInRoleAsync(user, role.Name).Result).ToList()
            }).ToList();

            return View(roles);
        }

        // GET: /RoleAdmin/HireAdmin
        public IActionResult HireAdmin() => View(new RegisterViewModel());

        // POST: /RoleAdmin/HireAdmin
        [HttpPost]
        public async Task<ActionResult> HireAdmin(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Validate that the user is at least 18 years old
                if ((DateTime.Now - model.DOB).TotalDays / 365 < 18)
                {
                    ModelState.AddModelError("DOB", "You must be at least 18 years old to create an account.");
                    return View(model);
                }

                var admin = new AppUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber,
                    Address = model.Address,
                    DOB = model.DOB
                };

                var result = await _userManager.CreateAsync(admin, model.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(admin, "Admin");
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        // GET: /RoleAdmin/FireAdmin
        public async Task<ActionResult> FireAdmin(string id)
        {
            var admin = await _userManager.FindByIdAsync(id);
            if (admin == null) return NotFound();

            admin.LockoutEnabled = true;
            await _userManager.UpdateAsync(admin);
            return RedirectToAction("Index");
        }

        // GET: /RoleAdmin/RehireAdmin
        public async Task<ActionResult> RehireAdmin(string id)
        {
            var admin = await _userManager.FindByIdAsync(id);
            if (admin == null) return NotFound();

            admin.LockoutEnabled = false;
            await _userManager.UpdateAsync(admin);
            return RedirectToAction("Index");
        }

        // GET: /RoleAdmin/ModifyProfile
        public async Task<ActionResult> ModifyProfile(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            var model = new ModifyProfile
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                Address = user.Address,
                DOB = user.DOB
            };

            return View(model);
        }

        // POST: /RoleAdmin/ModifyProfile
        [HttpPost]
        public async Task<ActionResult> ModifyProfile(string id, ModifyProfile model)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            if (ModelState.IsValid)
            {
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.PhoneNumber = model.PhoneNumber;
                user.Address = model.Address;
                user.DOB = model.DOB;

                if (!string.IsNullOrEmpty(model.NewPassword))
                {
                    var passwordToken = await _userManager.GeneratePasswordResetTokenAsync(user);
                    var result = await _userManager.ResetPasswordAsync(user, passwordToken, model.NewPassword);

                    if (!result.Succeeded)
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                        return View(model);
                    }
                }

                var updateResult = await _userManager.UpdateAsync(user);
                if (updateResult.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in updateResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }
    }
}
