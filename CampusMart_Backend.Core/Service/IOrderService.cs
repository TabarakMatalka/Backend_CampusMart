using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Service
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        Order GetOrderByID(int orderID);
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int orderID);
    }
}
