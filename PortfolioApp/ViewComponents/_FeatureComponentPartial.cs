using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
