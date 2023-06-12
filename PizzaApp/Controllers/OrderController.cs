using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models;

namespace PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("ListOrders")]
        public IActionResult Index()
        {
            List<Order> Orders = StaticOrder.Orders;
            return View(Orders);
        }

        [Route("details/{id?}")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error", "Home");
            }

            Order order = StaticOrder.Orders.FirstOrDefault(x => x.Id == id);

            if (order == null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(order);
        }

        [Route("Json")]
        public IActionResult GetJson()
        {
            Order order = new Order()
            {
                Id = 3,
                Name = "Capriciosa"
            };

            return new JsonResult(order);
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
