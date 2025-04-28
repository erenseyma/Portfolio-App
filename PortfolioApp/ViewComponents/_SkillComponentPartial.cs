using Microsoft.AspNetCore.Mvc;
using PortfolioApp.DAL.Context;

namespace PortfolioApp.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        PortfolioContext _context=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values =_context.Skills.ToList();
            return View(values);
        }
    }
}
