using Microsoft.AspNetCore.Mvc;
using PortfolioApp.DAL.Context;

namespace PortfolioApp.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        PortfolioContext _context=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=_context.Experiences.ToList();
            return View(values);
        }
    }
}
