using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models;
using PizzaApp.Models.Mapper;
using PizzaApp.Models.View_Models.PizzaViewModels;

namespace PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> Pizzas = StaticDb.Pizzas;
            List<PizzaViewModel> PizzaList = Pizzas.Select(x => x.MapFromPizzaToPizzaViewModel()).ToList();
            return View(PizzaList);
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Error");
            }

            Pizza pizzaDb = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);

            if(pizzaDb == null)
            {
                return RedirectToAction("Error", "Home");
            }

            PizzaViewModel pizzaDetails = pizzaDb.MapFromPizzaToPizzaViewModel();

            return View(pizzaDetails);
        }
    }
}
