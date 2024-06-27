using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.FluentValidation;
using BusinessLayer.Container;
using DataAccessLayer.Contrete.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net.Sockets;

namespace newProject.Controllers
{
    public class AddressController : Controller
    {
        IAddressService AddressManager = InstanceFactory.GetInstance<IAddressService>();
        public IActionResult Index()
        {
            var values =AddressManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult updateAddress(int id)
        {
            var values=AddressManager.GetaccordingtoId(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult updateAddress(Address address)
        {
            AddressValidation validationRules = new AddressValidation();    
            var result=validationRules.Validate(address);
            if (ModelState.IsValid)
            {
                AddressManager.Update(address);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
