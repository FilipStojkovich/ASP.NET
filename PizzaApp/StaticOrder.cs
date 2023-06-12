using PizzaApp.Models;

namespace PizzaApp
{
    public static class StaticOrder
    {
        public static List<Order> Orders = new List<Order>()
        {
            new Order()
            {
                Id = 1,
                Name = "Capri"
            },
            new Order()
            {
                Id = 2,
                Name = "Pepperoni"
            }
        };
    }
}
