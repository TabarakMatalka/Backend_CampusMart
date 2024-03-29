using CampusMart_Backend.Core.Common;
using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Repository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Infra.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IDbContext dbContext;

        public OrderRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Order> GetAllOrders()
        {
            IEnumerable<Order> result = dbContext.Connection.Query<Order>("Order_Package.GetAllOrders", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Order GetOrderByID(int orderID)
        {
            var p = new DynamicParameters();
            p.Add("order_OrderID", orderID, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Order>("Order_Package.GetOrderByID", p, commandType: CommandType.StoredProcedure);

            return result;
        }

        public void CreateOrder(Order order)
        {
            var p = new DynamicParameters();
            p.Add("order_OrderNumber", order.Ordernumber, DbType.String, ParameterDirection.Input);
            p.Add("order_OrderStatus", order.Orderstatus, DbType.String, ParameterDirection.Input);
            p.Add("order_TotalAmount", order.Totalamount, DbType.Decimal, ParameterDirection.Input);
            p.Add("order_Location", order.Location, DbType.String, ParameterDirection.Input);
            p.Add("order_DeliveryAddress", order.Deliveryaddress, DbType.String, ParameterDirection.Input);
            p.Add("order_OrderDate", order.Orderdate, DbType.DateTime, ParameterDirection.Input);
            p.Add("order_ConsumerID", order.Consumerid, DbType.Int32, ParameterDirection.Input);
            p.Add("order_ProviderID", order.Providerid, DbType.Int32, ParameterDirection.Input);
            p.Add("order_PaymentID", order.Paymentid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Order_Package.Create_Order", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateOrder(Order order)
        {
            var p = new DynamicParameters();
            p.Add("order_OrderID", order.Orderid, DbType.Int32, ParameterDirection.Input);
            p.Add("order_OrderNumber", order.Ordernumber, DbType.String, ParameterDirection.Input);
            p.Add("order_OrderStatus", order.Orderstatus, DbType.String, ParameterDirection.Input);
            p.Add("order_TotalAmount", order.Totalamount, DbType.Decimal, ParameterDirection.Input);
            p.Add("order_Location", order.Location, DbType.String, ParameterDirection.Input);
            p.Add("order_DeliveryAddress", order.Deliveryaddress, DbType.String, ParameterDirection.Input);
            p.Add("order_OrderDate", order.Orderdate, DbType.DateTime, ParameterDirection.Input);
            p.Add("order_ConsumerID", order.Consumerid, DbType.Int32, ParameterDirection.Input);
            p.Add("order_ProviderID", order.Providerid, DbType.Int32, ParameterDirection.Input);
            p.Add("order_PaymentID", order.Paymentid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Order_Package.Update_Order", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteOrder(int orderID)
        {
            var p = new DynamicParameters();
            p.Add("order_OrderID", orderID, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Order_Package.DeleteOrder", p, commandType: CommandType.StoredProcedure);
        }
    }

}
