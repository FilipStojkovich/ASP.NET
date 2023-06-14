using PizzaApp.Models.Enus;

namespace PizzaApp.Models.View_Models.OrderViewModels
{
    public class OrderDetailsViewModel
    {
        public string PizzaName { get; set; } = string.Empty;
        public string UserFullName { get; set; } = string.Empty;
        public string UserAddress { get; set; } = string.Empty;
        public int Price { get; set; }
        public PaymentMethods PaymentMethod { get; set; }
    }
}
