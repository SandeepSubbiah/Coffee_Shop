using CoffeeShop.Models;
using CoffeeShop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CoffeeShop.Controllers
{
    /*
    public class SoldItemsController : Controller
    {
        public IActionResult OrderHistory()
        {
            // In a real application, replace this with a call to your database to get the sold items.
            var soldItems = new List<SoldItem>
            {
                new SoldItem { ItemName = "Coffee Mug", Quantity = 10, Price = 5.99M, DateSold = DateTime.Now.AddDays(-1) },
                new SoldItem { ItemName = "T-Shirt", Quantity = 5, Price = 15.99M, DateSold = DateTime.Now.AddDays(-2) },
                // Add more items as needed
            };

            return View(soldItems);
        }
        
    } */

    public class OrderDetailsController : Controller 
    {
        private IOrderDetailsRepository _orderDetailsRepository;

        public OrderDetailsController(IOrderDetailsRepository soldItemsRepository)
        {
            _orderDetailsRepository = soldItemsRepository;
        }

        public IActionResult OrderHistory()
        {
            var soldItems = _orderDetailsRepository.GetSoldItems();
            return View(soldItems); // Passing the list of sold items to the view
        }
    }

}
