using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models;
using PizzaApp.Models.Mapper;
using PizzaApp.Models.View_Models.OrderViewModels;

namespace PizzaApp.Controllers
{
	public class OrderController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Details(int? id)
		{
			Order orderDb = StaticDb.Orders.FirstOrDefault(o => o.Id == id);

			OrderDetailsViewModel orderDetails = orderDb.MapFromOrderToOrderDetailsViewModel();

			return View();
		}
	}
}
