using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using newProject.Models;

namespace newProject.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        public ProfileController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {

            var result = await _userManager.FindByNameAsync(User.Identity.Name);
            ProfileViewModel profileViewModel = new ProfileViewModel();
            profileViewModel.mail = result.Email;
            profileViewModel.userName = result.UserName;
            profileViewModel.phono = result.PhoneNumber;
            return View(profileViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(ProfileViewModel profileViewModel)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            if (profileViewModel.password==profileViewModel.passwordConfirm)
            {

            
            values.UserName = profileViewModel.userName;
            values.PhoneNumber = profileViewModel.phono;
            values.Email = profileViewModel.mail;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, profileViewModel.password);
                var result = await _userManager.UpdateAsync(values);
                if (result.Succeeded)
                {
                    RedirectToAction("Index", "Login");
                }
                else
                {
                    RedirectToAction("index");
                }
            }
            return View();
        }
    }
}
