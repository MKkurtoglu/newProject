using BusinessLayer.Concrete;
using DataAccessLayer.Contrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Compenents
{
    public class AttentionViewComponent : ViewComponent
    {
        AttentionManager attentionManager = new AttentionManager(new EfAttentionDal());
        public IViewComponentResult Invoke()
        {
            var values =attentionManager.GetAll();
            return View(values);
        }
    }
}
