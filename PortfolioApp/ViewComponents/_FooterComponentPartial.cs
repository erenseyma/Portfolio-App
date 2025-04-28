using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
