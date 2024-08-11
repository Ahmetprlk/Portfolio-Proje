using Microsoft.AspNetCore.Mvc;

namespace PortfolioProjectAPP.ViewComponents
{
    public class _WorkComponentPartial  : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}
