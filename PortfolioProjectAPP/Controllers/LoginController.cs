using Microsoft.AspNetCore.Mvc;

namespace PortfolioProjectAPP.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
