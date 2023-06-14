using PizzaApp.Models.Enus;

namespace PizzaApp.Models.View_Models.PizzaViewModels
{
	public class PizzaViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int Price { get; set; }
		public PizzaSize PizzaSize { get; set; }
	}
}
