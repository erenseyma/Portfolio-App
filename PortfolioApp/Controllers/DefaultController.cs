using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
