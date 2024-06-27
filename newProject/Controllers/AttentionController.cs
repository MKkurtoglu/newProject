using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Container;
using DataAccessLayer.Contrete.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace newProject.Controllers
{
    public class AttentionController : Controller
    {
        IAttentionService attentionManager = InstanceFactory.GetInstance<IAttentionService>();

        public IActionResult Index()
        {
            var values = attentionManager.GetAll();
            return View(values);
        }
        public IActionResult deleteAttention(int id)
        {
            var values = attentionManager.GetaccordingtoId(id);
            attentionManager.Delete(values);
            return View();
        }
        public IActionResult addAttention()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addAttention(Attention attention)
        {
            attentionManager.Insert(attention);
            return RedirectToAction("index");
        }
        public IActionResult updateAttention(int id)
        {
            var values = attentionManager.GetaccordingtoId(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult updateAttention(Attention attention)
        {
            attentionManager.Update(attention);
            return RedirectToAction("index");
        }
    }
}
