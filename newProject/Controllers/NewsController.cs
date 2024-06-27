using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Container;
using DataAccessLayer.Contrete.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Controllers
{
    public class NewsController : Controller
    {
        INewService NewsManager = InstanceFactory.GetInstance<INewService>();

        public IActionResult Index()
        {
            var values =NewsManager.GetAll();
            return View(values);
        }
        public IActionResult addNews()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addNews(News news)
        {
            news.NewsDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            news.Status = false;
            NewsManager.Insert(news);
            return RedirectToAction("index");
        }
        public IActionResult updateNews(int id)
        {
            var values =NewsManager.GetaccordingtoId(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult updateNews(News news)
        {
            news.NewsDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            
            NewsManager.Update(news);
            return RedirectToAction("index");
        }
        public IActionResult deleteNews(int id)
        {
            NewsManager.Delete(NewsManager.GetaccordingtoId(id));
            return RedirectToAction("index");
        }
        public IActionResult statusTrue(int id)
        {
            NewsManager.statusChanceToTrue(id);
            return RedirectToAction("index");
        }
        public IActionResult statusFalse(int id)
        {
            NewsManager.statusChanceToFalse(id);
            return RedirectToAction("index");
        }
    }
}
