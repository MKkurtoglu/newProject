using BusinessLayer.Concrete;
using DataAccessLayer.Contrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Compenents
{
    public class AboutPageServiceViewComponent : ViewComponent
    {
        ServiceManager ServiceManager = new ServiceManager(new EfServicesDal());
        public IViewComponentResult Invoke()
        {
            var values =ServiceManager.GetAll();
            return View(values);
        }
    }
}
