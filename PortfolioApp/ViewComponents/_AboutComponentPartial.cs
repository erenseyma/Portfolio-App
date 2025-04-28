using Microsoft.AspNetCore.Mvc;
using PortfolioApp.DAL.Context;

namespace PortfolioApp.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        PortfolioContext _context=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle =_context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDexcription=_context.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail=_context.Abouts.Select(x=>x.Details).FirstOrDefault();
            return View();
        }
    }
}
