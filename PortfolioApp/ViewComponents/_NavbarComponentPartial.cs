using Microsoft.AspNetCore.Mvc;
using PortfolioApp.DAL.Context;

namespace PortfolioApp.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        PortfolioContext context=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = context.ToDoLists.Where(x => x.Status == false).Count();
            var values=context.ToDoLists.Where(x=>x.Status == false).ToList();
            return View(values);
        }
    }
}
