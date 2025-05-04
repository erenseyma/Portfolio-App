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
			todolist.Status = false;
			context.ToDoLists.Add(todolist);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeleteToDoList(int id)
		{
			var values= context.ToDoLists.Find(id);
			context.ToDoLists.Remove(values);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateToDoList(int id)
		{
			var values = context.ToDoLists.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateToDoList(ToDoList todolist)
		{
			context.ToDoLists.Update(todolist);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
