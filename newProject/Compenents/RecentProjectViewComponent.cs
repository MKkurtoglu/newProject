using BusinessLayer.Concrete;
using DataAccessLayer.Contrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Compenents
{
    public class RecentProjectViewComponent : ViewComponent
    {
        RecentProjectManager RecentProjectManager = new RecentProjectManager(new EfRecentProjectDal());
        public IViewComponentResult Invoke()
        {
            var values =RecentProjectManager.GetAll();
            return View(values);
        }
    }
}
