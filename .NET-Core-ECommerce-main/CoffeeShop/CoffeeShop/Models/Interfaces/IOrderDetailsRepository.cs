namespace CoffeeShop.Models.Interfaces
{
    public interface IOrderDetailsRepository
    {
        IEnumerable<OrderDetail> GetSoldItems();
    }
}
