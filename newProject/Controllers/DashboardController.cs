using Microsoft.AspNetCore.Mvc;

namespace newProject.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
