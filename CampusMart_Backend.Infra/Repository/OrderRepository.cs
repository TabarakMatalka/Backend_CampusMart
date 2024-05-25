using CampusMart_Backend.Core.Common;
using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.DTO;
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
    public class OrdersRepository : IOrdersRepository
    {
       private readonly IDbContext dbContext;

        public OrdersRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

     /*   public List<Order> GetAllOrders()
        {

            IEnumerable<Order> result = dbContext.Connection.Query<Order>("Orders_Package.GetAllOrders", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }*/

        public List<Order> GetAllOrders()
        {
            IEnumerable<Order> result = dbContext.Connection.Query<Order>("GetAllOrders", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Order GetOrderById(int orderId)
        {
            var p = new DynamicParameters();
            p.Add("p_OrderID", orderId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Order>("Orders_Package.GetOrderById", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public void CreateOrder(Order order)
        {
            var p = new DynamicParameters();
            p.Add("p_OrderNumber", order.Ordernumber, DbType.String, ParameterDirection.Input);
            p.Add("p_OrderStatus", order.Orderstatus, DbType.String, ParameterDirection.Input);
            p.Add("p_TotalAmount", order.Totalamount, DbType.Decimal, ParameterDirection.Input);
            p.Add("p_Location", order.Location, DbType.String, ParameterDirection.Input);
            p.Add("p_LOCATION_LATITUDE", order.LOCATION_LATITUDE, DbType.String, ParameterDirection.Input);
            p.Add("p_LOCATION_LONGITUDE", order.LOCATION_LONGITUDE, DbType.String, ParameterDirection.Input);
            p.Add("p_DeliveryAddress", order.Deliveryaddress, DbType.String, ParameterDirection.Input);
            p.Add("p_OrderDate", order.Orderdate, DbType.DateTime, ParameterDirection.Input);
            p.Add("p_ConsumerID", order.Consumerid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_ProviderID", order.Providerid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_PaymentID", order.Paymentid, DbType.Int32, ParameterDirection.Input);

            dbContext.Connection.Execute("Orders_Package.CreateOrder", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateOrder(Order order)
        {
            var p = new DynamicParameters();
            p.Add("p_OrderID", order.Orderid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_OrderNumber", order.Ordernumber, DbType.String, ParameterDirection.Input);
            p.Add("p_OrderStatus", order.Orderstatus, DbType.String, ParameterDirection.Input);
            p.Add("p_TotalAmount", order.Totalamount, DbType.Decimal, ParameterDirection.Input);
            p.Add("p_Location", order.Location, DbType.String, ParameterDirection.Input);
            p.Add("p_LOCATION_LATITUDE", order.LOCATION_LATITUDE, DbType.String, ParameterDirection.Input);
            p.Add("p_LOCATION_LONGITUDE", order.LOCATION_LONGITUDE, DbType.String, ParameterDirection.Input);
            p.Add("p_DeliveryAddress", order.Deliveryaddress, DbType.String, ParameterDirection.Input);
            p.Add("p_OrderDate", order.Orderdate, DbType.DateTime, ParameterDirection.Input);
            p.Add("p_ConsumerID", order.Consumerid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_ProviderID", order.Providerid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_PaymentID", order.Paymentid, DbType.Int32, ParameterDirection.Input);

            dbContext.Connection.Execute("Orders_Package.UpdateOrder", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteOrder(int orderId)
        {
            var p = new DynamicParameters();
            p.Add("p_OrderID", orderId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Orders_Package.DeleteOrder", p, commandType: CommandType.StoredProcedure);
        }

       
    }


}
