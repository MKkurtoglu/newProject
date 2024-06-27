using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Container;
using DataAccessLayer.Contrete.EntityFramework;
using DataAccessLayer.Migrations;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Controllers
{
    public class AdminController : Controller
    {
        IAdminService adminManager = InstanceFactory.GetInstance<IAdminService>();

        public IActionResult Index()
        {
           var values = adminManager.GetAll();
            return View(    values);
        }
        public IActionResult addAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addAdmin(Admin admin)
        {
            adminManager.Insert(admin);
            return RedirectToAction("index");
        }
        public IActionResult updateAdmin(int id,string admin)
        {
            var values=adminManager.GetaccordingtoId(id);
            
            return View(values);
                
        }
        [HttpPost]
        public IActionResult updateAdmin(Admin admin)
        {
            adminManager.Update(admin);
            return RedirectToAction("index");
        }
        public IActionResult deleteAdmin(int id)
        {
          var values=  adminManager.GetaccordingtoId(id);
            adminManager.Delete(values);
            return RedirectToAction("index");
        }
    }
}
