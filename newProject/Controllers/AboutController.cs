using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Container;
using DataAccessLayer.Contrete.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Controllers
{
    public class AboutController : Controller
    {
        IAboutService AboutManager = InstanceFactory.GetInstance<IAboutService>();
        public IActionResult About()
        {
            
            return View();
        }
        public IActionResult Index()
        {
            var values = AboutManager.GetAll();
            return View(values);
        }
        public IActionResult updateAbout(int id)
        {
            var values = AboutManager.GetaccordingtoId(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult updateAbout(About about)
        {
            AboutManager.Update(about);
            return RedirectToAction("index");
        }
        public IActionResult deleteAbout(int id)
        {
            var values = AboutManager.GetaccordingtoId(id);
            AboutManager.Delete(values);
            return RedirectToAction("index");
        }
    }
}
