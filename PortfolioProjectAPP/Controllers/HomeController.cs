using Microsoft.AspNetCore.Mvc;
using PortfolioProjectAPP.DAL.Context;
using PortfolioProjectAPP.DAL.Entities;
using PortfolioProjectAPP.Models;
using System.Diagnostics;

namespace PortfolioProjectAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
