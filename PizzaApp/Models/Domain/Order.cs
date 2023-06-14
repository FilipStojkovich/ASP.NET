using PizzaApp.Models.Domain;
using PizzaApp.Models.Enus;

namespace PizzaApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int PizzaId { get; set; }
        public int UserId { get; set; }
        public Pizza Pizza { get; set; }
        public User User { get; set; }
        public PaymentMethods PaymentMethod { get; set; }
    }
}
