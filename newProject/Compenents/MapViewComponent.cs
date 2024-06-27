using DataAccessLayer.Contrete;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Compenents
{
    public class MapViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ProjectDbContext dbContext = new ProjectDbContext();
            var values = dbContext.Addresses.Select(x=>x.MapInfo).FirstOrDefault();
            ViewBag.x=values;
            return View();
        }
    }
}
