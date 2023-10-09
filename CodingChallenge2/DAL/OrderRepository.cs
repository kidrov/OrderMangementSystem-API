using System;
using System.Collections.Generic;
using System.Linq;
using OrderManagementSystem;
using OrderManagementSystem.DAL;
using OrderManagementSystem.Models;

namespace DAL
{
    // Repository class is used to implement all Data access operations
    public class OrderRepository : IOrderRepository
    {
        private readonly KeepDbContext _dbContext;

        public OrderRepository(KeepDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Order PlaceOrder(Order order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
            return order;
        }

        public List<Order> GetAllOrdersByUserId(int userId)
        {
            string userIdStr = userId.ToString();
            return _dbContext.Orders.Where(r => r.UserId == userIdStr).ToList();
        }


    }
}
