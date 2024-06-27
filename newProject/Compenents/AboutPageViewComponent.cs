using BusinessLayer.Concrete;
using DataAccessLayer.Contrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Compenents
{
    public class AboutPageViewComponent : ViewComponent
    {
        AboutManager AboutManager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values =AboutManager.GetAll();
            return View(values);
        }
    }
}
