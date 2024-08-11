using Microsoft.AspNetCore.Mvc;

namespace PortfolioProjectAPP.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
