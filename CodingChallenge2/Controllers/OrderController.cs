using OrderManagementSystem.Models;
using OrderManagementSystem.DAL;
using OrderManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace KeepNote.Controllers
{
    [ApiController]
    [Route("api/order")] // Base route for ReminderController
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public IActionResult PlaceOrder(Order order)
        {
            // Call the ReminderService to create a reminder
            var placeOrder = _orderService.PlaceOrder(order);
            return Created("", placeOrder); // 201 Created
        }

        [HttpGet("{userId}")]
        public IActionResult GetOrdersByUserId(int userId)
        {
            // Call the OrderService to get orders by user ID
            var orders = _orderService.GetAllOrdersByUserId(userId);
            return Ok(orders); // 200 OK
        }
    }
}
