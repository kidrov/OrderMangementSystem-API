using System;
using System.Collections.Generic;
using OrderManagementSystem.DAL;
using OrderManagementSystem.Models;

namespace Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order PlaceOrder(Order order)
        {
            // Business logic and validation (if needed)
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order), "Order cannot be null.");
            }

            // Call the repository to create the reminder
            return _orderRepository.PlaceOrder(order);
        }

        public List<Order> GetAllOrdersByUserId(int userId)
        {
            // Call the repository to get reminders by user ID
            return _orderRepository.GetAllOrdersByUserId(userId);
        }

      
 
    }
}
