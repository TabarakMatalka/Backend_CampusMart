//using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Repository
{
    public interface IOrdersRepository
    {
        List<Order> GetAllOrders();
        Order GetOrderById(int orderId);
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int orderId);
        List<ConsumersOrders> GetConsumerOrdersbyProviderId(int providerID);
        public void AcceptOrder(int orderID);
    }

}
