using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Container;
using DataAccessLayer.Contrete.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Controllers
{
    [AllowAnonymous]
    public class RecentProjectController : Controller
    {
        IRecentProjectService RecentProjectManager = InstanceFactory.GetInstance<IRecentProjectService>();
        
        public IActionResult Index()
        {
            var values = RecentProjectManager.GetAll();
            
            return View(values);
        }
        public IActionResult addRecent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addRecent(RecentProject recentProject)
        {
            RecentProjectManager.Insert(recentProject);
            return RedirectToAction("index");
        }
        public IActionResult deleteRecent(int id)
        {
            var values = RecentProjectManager.GetaccordingtoId(id);
            RecentProjectManager.Delete(values);
            return RedirectToAction("index");
        }
        public IActionResult updateRecent(int id)
        {
            var values = RecentProjectManager.GetaccordingtoId(id);
            
            return View(values);
        }
        [HttpPost]
        public IActionResult updateRecent(RecentProject recentProject)
        {
            RecentProjectManager.Update(recentProject);
            return RedirectToAction("index");
        }

    }
}
