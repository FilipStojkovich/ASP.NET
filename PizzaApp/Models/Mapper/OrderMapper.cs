using PizzaApp.Models.View_Models.OrderViewModels;

namespace PizzaApp.Models.Mapper
{
    public static class OrderMapper
	{
		public static OrderDetailsViewModel MapFromOrderToOrderDetailsViewModel(this Order order)
		{
			return new OrderDetailsViewModel()
			{
				PaymentMethod = order.PaymentMethod,
				PizzaName = order.Pizza.Name,
				UserFullName = $"{order.User.FirstName} {order.User.LastName}",
				UserAddress = order.User.Address,
				Price = order.Pizza.Price
			};
		}
	}
}
