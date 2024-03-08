using CoffeeShop.Data;
using CoffeeShop.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Models.Services
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        private CoffeeShopDbContext _context;

        public OrderDetailsRepository(CoffeeShopDbContext context)
        {
            _context = context;
        }

        public IEnumerable<OrderDetail> GetSoldItems()
        {
            // This might need adjustments based on your actual DB schema and needs
            return _context.OrderDetails.Include(si => si.Product).ToList();
        }

        public IEnumerable<OrderDetail> GetOrderDetailsWithProductNames()
        {
            var orderDetailsWithProducts = _context.OrderDetails
                                                   .Include(od => od.Product) // Eager load the Product navigation property
                                                   .ToList();

            return orderDetailsWithProducts;
        }

    }
}
