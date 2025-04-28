using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
