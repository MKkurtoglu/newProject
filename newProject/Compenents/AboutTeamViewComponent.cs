using BusinessLayer.Concrete;
using DataAccessLayer.Contrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Compenents
{
    public class AboutTeamViewComponent : ViewComponent
    {
        TeamManager TeamManager = new TeamManager(new EfTeamDal());
        public IViewComponentResult Invoke()
        {
            var values = TeamManager.GetAll();
            
            return View(values);
        }
    }
}
