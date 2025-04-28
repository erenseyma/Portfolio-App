using Microsoft.AspNetCore.Mvc;
using PortfolioApp.DAL.Context;

namespace PortfolioApp.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        PortfolioContext _context=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values= _context.Features.ToList();
            return View(values);
        }
    }
}
