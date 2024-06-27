using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult yeni()
        {
            return View();
        }
    }
}
