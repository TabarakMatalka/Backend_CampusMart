using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.DTO;
using CampusMart_Backend.Core.Repository;
using CampusMart_Backend.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Infra.Service
{

    public class OrderService : IOrderService
    {
        private readonly IOrdersRepository orderRepository;

        public OrderService(IOrdersRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public void CreateOrder(Order order)
        {
            this.orderRepository.CreateOrder(order);
        }

        public void DeleteOrder(int orderID)
        {
            this.orderRepository.DeleteOrder(orderID);
        }

        public List<Order> GetAllOrders()
        {
            return this.orderRepository.GetAllOrders();
        }

        public Order GetOrderByID(int orderID)
        {
            return this.orderRepository.GetOrderById(orderID);
        }

        public void UpdateOrder(Order order)
        {
            this.orderRepository.UpdateOrder(order);
        }
        public List<ConsumersOrders> GetConsumerOrdersbyProviderId(int providerID)
        {
            return this.orderRepository.GetConsumerOrdersbyProviderId(providerID);
        }
        public void AcceptOrder(int orderID)
        {
            this.orderRepository.AcceptOrder(orderID);
        }
    }
}
