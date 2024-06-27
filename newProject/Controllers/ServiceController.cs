using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Container;
using DataAccessLayer.Contrete.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace newProject.Controllers
{
    public class ServiceController : Controller
    {
        
        IServiceService serviceManager = InstanceFactory.GetInstance<IServiceService>();
        public IActionResult Index()
        {
            var values=serviceManager.GetAll();
            return View(values);
        }
        public IActionResult Addservice()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addservice(Services services)
        {
            serviceManager.Insert(services);
            return RedirectToAction("index");
        }
        public IActionResult Deleteservice(int id)
        {
            var values= serviceManager.GetaccordingtoId(id);
            serviceManager.Delete(values);
            return RedirectToAction("index");
        }
        public IActionResult updateService(int id)
        {
            var values = serviceManager.GetaccordingtoId(id);
            serviceManager.Update(values);
            return View(values);
        }
        [HttpPost]
        public IActionResult updateService(Services services)
        {
            serviceManager.Update(services);
            return RedirectToAction("index");

        }
        public IActionResult deneme()
        {
            return View();
        }
    }
}
