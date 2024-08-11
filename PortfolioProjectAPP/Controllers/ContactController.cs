using Microsoft.AspNetCore.Mvc;
using PortfolioProjectAPP.DAL.Context;

namespace PortfolioProjectAPP.Controllers
{
    public class ContactController : Controller
    {
        private readonly Context context;
        public IActionResult ContactList()
        {
            var messages = context.Contacts.ToList();
            return View(messages);
        }
    }
}
