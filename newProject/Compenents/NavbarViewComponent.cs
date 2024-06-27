using Microsoft.AspNetCore.Mvc;

namespace newProject.Compenents
{
    public class NavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
