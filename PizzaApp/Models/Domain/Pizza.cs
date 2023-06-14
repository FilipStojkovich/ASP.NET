using PizzaApp.Models.Enus;

namespace PizzaApp.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public decimal DecimalPrice { get; set; }
        public bool IsOnPromotion { get; set; }
        public bool HasExtras { get; set; }
        public string? ImageUrl { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
        public List<string> PizzaSizes { get; set; } = new List<string>();
    }
}
