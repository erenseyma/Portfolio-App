using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
