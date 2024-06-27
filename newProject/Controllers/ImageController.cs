using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.FluentValidation;
using BusinessLayer.Container;
using DataAccessLayer.Contrete.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace newProject.Controllers
{
    public class ImageController : Controller
    {
        IımageService ImageManager = InstanceFactory.GetInstance<IımageService>();

        public IActionResult Index()
        {
            var values = ImageManager.GetAll();
            return View(values);
        }
        public IActionResult deleteImage(int id)
        {
            var values = ImageManager.GetaccordingtoId(id);
            ImageManager.Delete(values);
            return RedirectToAction("Index");
        }
        public IActionResult addImage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addImage(Image image)
        {
            ImageValidator validationRules = new ImageValidator();
            var validationResult = validationRules.Validate(image);
            if (ModelState.IsValid)
            {
                ImageManager.Insert(image);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult updateImage(int id)
        {
            var values = ImageManager.GetaccordingtoId(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult updateImage(Image image)
        {
            ImageValidator validationRules = new ImageValidator();
            var validationResult = validationRules.Validate(image);
            if (ModelState.IsValid)
            {
                ImageManager.Update(image);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult Image ()
        {

            return View();
        }
    }
}
