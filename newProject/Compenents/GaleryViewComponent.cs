using BusinessLayer.Concrete;
using DataAccessLayer.Contrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Compenents
{
    public class GaleryViewComponent : ViewComponent
    {
        ImageManager ImageManager = new ImageManager(new EfImageDal());
        public IViewComponentResult Invoke()
        {
            var values =ImageManager.GetAll();
            return View(values);
        }
    }
}
