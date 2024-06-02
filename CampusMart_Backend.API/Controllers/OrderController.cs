using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.DTO;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet]
        [Route("GetAllOrders")]
        public List<Order> GetAllOrders()
        {
            return orderService.GetAllOrders();
        }

        [HttpGet]
        [Route("GetOrderByID/{id}")]
        public Order GetOrderByID(int id)
        {
            return orderService.GetOrderByID(id);
        }

        [HttpPost]
        [Route("CreateOrder")]
        public void CreateOrder(Order order)
        {
            orderService.CreateOrder(order);
        }

        [HttpPut]
        [Route("UpdateOrder")]
        public void UpdateOrder(Order order)
        {
            orderService.UpdateOrder(order);
        }

        [HttpDelete]
        [Route("DeleteOrder/{id}")]
        public void DeleteOrder(int id)
        {
            orderService.DeleteOrder(id);
        }

        [HttpGet]
        [Route("GetConsumerOrdersbyProviderId")]
        public List<ConsumersOrders> GetConsumerOrdersbyProviderId(int providerID)
        {
            return this.orderService.GetConsumerOrdersbyProviderId(providerID);
        }
        [HttpPut]
        [Route("AcceptOrder")]
        public void AcceptOrder(int orderID)
        {
            this.orderService.AcceptOrder(orderID);
        }
    }
}
