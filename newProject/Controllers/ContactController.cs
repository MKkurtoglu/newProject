using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Container;
using DataAccessLayer.Contrete.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Controllers
{
    public class ContactController : Controller
    {
        IContactService ContactManager = InstanceFactory.GetInstance<IContactService>();

        public IActionResult Index()
        {
            var values=ContactManager.GetAll();
            return View(values);
        }
        public IActionResult deleteContact(int id)
        {
            var values = ContactManager.GetaccordingtoId(id);
            ContactManager.Delete(values);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var values = ContactManager.GetaccordingtoId(id);
            return View(values);
        }
        public PartialViewResult addContact()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult addContact(Contact contact)
        {
            contact.MessageDate = DateTime.Now;
            ContactManager.Insert(contact);
            return RedirectToAction("index","Default");
        }
    }
}
