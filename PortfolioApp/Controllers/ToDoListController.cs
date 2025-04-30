using Microsoft.AspNetCore.Mvc;
using PortfolioApp.DAL.Context;
using PortfolioApp.DAL.Entities;

namespace PortfolioApp.Controllers
{
	public class ToDoListController : Controller
	{
		PortfolioContext context = new PortfolioContext();
		public IActionResult Index()
		{
			var values=context.ToDoLists.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateToDoList()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateToDoList(ToDoList todolist)
		{
			context.ToDoLists.Add(todolist);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
