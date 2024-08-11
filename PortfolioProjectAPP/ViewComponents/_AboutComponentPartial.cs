using Microsoft.AspNetCore.Mvc;
using PortfolioProjectAPP.DAL.Context;

namespace PortfolioProjectAPP.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var data = context.About.ToList();
            return View(data); 
        }
    }
}
