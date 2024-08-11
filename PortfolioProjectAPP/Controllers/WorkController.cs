using Microsoft.AspNetCore.Mvc;
using PortfolioProjectAPP.DAL.Context;
using PortfolioProjectAPP.DAL.Entities;

namespace PortfolioProjectAPP.Controllers
{
    public class WorkController : Controller
    {
        Context  context = new Context();
        public IActionResult WorkList()
        {
            var data = context.Works.ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Works works)
        {
            context.Works.Add(works);
            context.SaveChanges();
            return RedirectToAction("WorkList");
        }

        public IActionResult Delete(int id) {

            var kayıt = context.Works.Find(id);
            context.Works.Remove(kayıt);
            context.SaveChanges();
            return RedirectToAction("WorkList");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var work = context.Works.Find(id);
            return View(work);
        }

        [HttpPost]
        public IActionResult Update(Works work)
        {
            context.Works.Update(work);
            context.SaveChanges();
            return RedirectToAction("WorkList");
        }
    }
}
