using System.Collections.Generic;
using OrderManagementSystem.Models;

namespace Service
{

    public interface IOrderService
    {
        Order PlaceOrder(Order order);
        List<Order> GetAllOrdersByUserId(int userId);
    }
}
