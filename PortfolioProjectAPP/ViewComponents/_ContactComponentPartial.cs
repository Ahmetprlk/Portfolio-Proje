using Microsoft.AspNetCore.Mvc;

namespace PortfolioProjectAPP.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
