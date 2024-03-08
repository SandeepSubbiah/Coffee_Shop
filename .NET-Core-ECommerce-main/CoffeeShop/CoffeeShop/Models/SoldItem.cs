namespace CoffeeShop.Models
{
    public class SoldItem
    {
        /*
        public string ItemName { get; set; }
        public int QuantitySold { get; set; }
        public decimal Price { get; set; }
        public DateTime DateSold { get; set; }
        */
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
