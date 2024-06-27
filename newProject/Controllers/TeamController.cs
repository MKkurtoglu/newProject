using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.FluentValidation;
using BusinessLayer.Container;
using DataAccessLayer.Contrete.EntityFramework;
using EntitiyLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
//using System.ComponentModel.DataAnnotations;

namespace newProject.Controllers
{
    public class TeamController : Controller
    {
        ITeamService teamManager = InstanceFactory.GetInstance<ITeamService>();

        public IActionResult Index()
        {
            var values = teamManager.GetAll();
            return View(values);
        }
        public IActionResult deleteTeam(int id)
        {
            var values= teamManager.GetaccordingtoId(id);
            teamManager.Delete(values);
            return RedirectToAction("Index");
        }
        public IActionResult addTeam()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult addTeam(Team team)
        {
            TeamValidator validationRules = new TeamValidator();
            ValidationResult validationResult = validationRules.Validate(team); //team den dönen değerleri kontrol ediyoruz
            if (ModelState.IsValid) //geçerli ise
            {
                teamManager.Insert(team);
                return RedirectToAction("index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    //modelstate mvc de type'ların data annnotonslarını kontrol eden ve geriye
                    //değer döndüren bir propert'dir.
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult updateTeam(int id)
        {
            var values = teamManager.GetaccordingtoId(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult updateTeam(Team team)
        {
            TeamValidator validationRules = new TeamValidator();
            ValidationResult validationResult = validationRules.Validate(team); //team den dönen değerleri kontrol ediyoruz
            if (ModelState.IsValid) //geçerli ise
            {
                teamManager.Update(team);
                return RedirectToAction("index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    //modelstate mvc de type'ların data annnotonslarını kontrol eden ve geriye
                    //değer döndüren bir propert'dir.
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
    }
}
