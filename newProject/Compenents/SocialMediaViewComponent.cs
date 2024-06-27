using BusinessLayer.Concrete;
using DataAccessLayer.Contrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace newProject.Compenents
{
    public class SocialMediaViewComponent : ViewComponent
    {
        SocialMediaManager SocialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
        public IViewComponentResult Invoke()
        {
            var values =SocialMediaManager.GetAll();
            return View(values);
        }
    }
}
