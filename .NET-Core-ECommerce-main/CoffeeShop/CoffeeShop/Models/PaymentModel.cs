﻿namespace CoffeeShop.Models
{
    public class PaymentModel
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; } = "USD";
    }
}
