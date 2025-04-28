using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.ViewComponents.LayoutViewCompenent
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
