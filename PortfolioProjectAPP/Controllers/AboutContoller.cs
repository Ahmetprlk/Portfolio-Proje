using Microsoft.AspNetCore.Mvc;

namespace PortfolioProjectAPP.Controllers
{
    public class AboutContoller : Controller
    {
        public IActionResult AboutList()
        {
            return View();
        }
    }
}
