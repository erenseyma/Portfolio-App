using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.ViewComponents.LayoutViewCompenent
{
	public class _LayoutScriptComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
