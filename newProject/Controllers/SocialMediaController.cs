using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Container;
using DataAccessLayer.Contrete.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Controllers
{
    public class SocialMediaController : Controller
    {
        ISocialMediaService socialMediaManager = InstanceFactory.GetInstance<ISocialMediaService>();

        public IActionResult Index()
        {
            var values =socialMediaManager.GetAll();
            return View(values);
        }
        public IActionResult updateSocial(int id)
        {
            var values = socialMediaManager.GetaccordingtoId(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult updateSocial(SocialMedia socialMedia)
        {
            socialMediaManager.Update(socialMedia);
            return RedirectToAction("index");
        }

    }
}
