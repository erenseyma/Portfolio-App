using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
