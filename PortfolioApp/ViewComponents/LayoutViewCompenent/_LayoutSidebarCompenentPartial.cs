using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.ViewComponents.LayoutViewCompenent
{
	public class _LayoutSidebarCompenentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
