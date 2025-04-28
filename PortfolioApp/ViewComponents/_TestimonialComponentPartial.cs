using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
