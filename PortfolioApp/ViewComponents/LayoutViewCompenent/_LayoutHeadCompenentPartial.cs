using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.ViewComponents.LayoutViewCompenent
{
	public class _LayoutHeadCompenentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
