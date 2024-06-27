using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using newProject.Models;

namespace newProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public LoginController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager= signInManager;
        }
        
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginViewModel.userName, loginViewModel.password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("index", "Contact");
                }
                else
                {
                    return RedirectToAction("index");
                }
            }
            return View();
        }
        //persistent --> tekrar hatırlasın mı 
        //lockoutonfailer --> 5 yanlış hata da bekleme süresi olsun mu
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterViewModel registerViewModel)
        {
            IdentityUser ıdentityUser = new IdentityUser()
            {
                Id="1",
                UserName=registerViewModel.userName, Email=registerViewModel.email,
                
            };
            if (registerViewModel.password==registerViewModel.passwordConfirm || registerViewModel.Status==true)
            {
                var result = await _userManager.CreateAsync(ıdentityUser, registerViewModel.passwordConfirm);
                if (result.Succeeded)
                {
                    return RedirectToAction("index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(registerViewModel);
        }
    }
}
