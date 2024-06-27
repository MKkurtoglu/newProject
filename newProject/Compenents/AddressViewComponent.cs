

using BusinessLayer.Concrete;
using DataAccessLayer.Contrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Compenents
{
    public class AddressViewComponent :ViewComponent
    {
        AddressManager AddressManager = new AddressManager(new EfAddressDal());
        public IViewComponentResult Invoke()
        {
            var values =AddressManager.GetAll();
            return View(values);
        }
    }
}
