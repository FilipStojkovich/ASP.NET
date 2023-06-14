using PizzaApp.Models;
using PizzaApp.Models.Domain;
using PizzaApp.Models.Enus;
using System.Reflection.Metadata.Ecma335;

namespace PizzaApp
{
    public static class StaticDb
    {
        public static int UserId = 2;
        public static List<Pizza> Pizzas = new List<Pizza>()
        {
            new Pizza()
            {
                Id = 1,
                Name = "Capri",
                Price = 300,
                IsOnPromotion = true,
                ImageUrl = @"https://hips.hearstapps.com/hmg-prod/images/classic-cheese-pizza-recipe-2-64429a0cb408b.jpg?crop=0.6666666666666667xw:1xh;center,top&resize=1200:*",
				Ingredients = new List<string>()
				{
					"Salami",
					"Pork/Chicken",
					"Cheese/Mozarella",
					"Mushrooms",
					"Ketchup",
					"Basil"
				},
				PizzaSizes = new List<string>()
				{
					"Small",
					"Medium",
					"Large",
					"Family"
				}
			},
            new Pizza()
            {
                Id = 2,
                Name = "Pepperoni",
                Price = 400,
                IsOnPromotion = false,
                ImageUrl = @"https://hips.hearstapps.com/hmg-prod/images/classic-cheese-pizza-recipe-2-64429a0cb408b.jpg?crop=0.6666666666666667xw:1xh;center,top&resize=1200:*",
                Ingredients = new List<string>()
                {
                    "Salami",
                    "Pork/Chicken",
                    "Cheese/Mozarella",
                    "Mushrooms",
                    "Ketchup",
                    "Basil"
                },
                PizzaSizes = new List<string>()
                {
                    "Small",
                    "Medium",
                    "Large",
                    "Family"
                }
            }
        };
        public static List<User> Users = new List<User>()
        {
            new User()
            {
                Id = 2,
                FirstName = "Bob",
                LastName = "Bobsky",
                PhoneNumber = "32743285"
            },
            new User()
            {
                Id = 2,
                FirstName = "Kate",
                LastName = "Katesky",
                PhoneNumber = "35892378435"
            }
        };
        public static List<Order> Orders = new List<Order>()
        {
            new Order()
            {
                Id = 1,
                PizzaId = 1,
                UserId = 2,
                Pizza = Pizzas.First(),
                User = Users.First(x => x.Id == 2),
                PaymentMethod = PaymentMethods.Cash
            },
            new Order()
            {
                Id = 2,
                PizzaId = 2,
                UserId = 2,
                Pizza = Pizzas.First(),
                User = Users.First(x => x.Id == 2),
                PaymentMethod = PaymentMethods.Card
            }
        };
    }
}
