using Microsoft.AspNetCore.Mvc;

namespace PortfolioProjectAPP.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult AdminLayout()
        {
            return View();
        }
    }
}
