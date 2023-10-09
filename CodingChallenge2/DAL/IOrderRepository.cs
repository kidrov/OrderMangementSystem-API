using OrderManagementSystem.Models;

namespace OrderManagementSystem.DAL
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrdersByUserId(int userId);
        
        Order PlaceOrder(Order order);
    }
}
