using BusinessLayer.Concrete;
using DataAccessLayer.Contrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Compenents
{
    public class NewsViewComponent : ViewComponent
    {
        NewsManager NewsManager = new NewsManager(new EfNewsDal());
        public IViewComponentResult Invoke ()
        {
            var values =NewsManager.GetAllStatus(true);
            return View(values);
        }
    }
}
