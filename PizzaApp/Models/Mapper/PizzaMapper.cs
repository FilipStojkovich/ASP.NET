using PizzaApp.Models.View_Models.PizzaViewModels;

namespace PizzaApp.Models.Mapper
{
	public static class PizzaMapper
	{
		public static PizzaListViewModel MapFromPizzaToPizzaListViewModel(this Pizza pizza)
		{
			return new PizzaListViewModel()
			{
				Id = pizza.Id,
				ImgUrl = pizza.ImageUrl,
				Name = pizza.Name,
				Price = pizza.Price
			};
		}

		public static PizzaDetailsViewModel MapFromPizzaToPizzaDetailsViewModel(this Pizza pizza)
		{
			return new PizzaDetailsViewModel()
			{
				ImageUrl = pizza.ImageUrl,
				Ingredients = pizza.Ingredients,
				IsOnPromotion = pizza.IsOnPromotion,
				Name = pizza.Name,
				PizzaSizes = pizza.PizzaSizes,
				Price = pizza.Price
			};
		}

		//Homework
		public static PizzaViewModel MapFromPizzaToPizzaViewModel(this Pizza pizza)
		{
			return new PizzaViewModel()
			{
				Id = pizza.Id,
				Name = pizza.Name,
				Price = pizza.Price,
				PizzaSize = pizza.PizzaSize,				
			};
		}
	}
}
