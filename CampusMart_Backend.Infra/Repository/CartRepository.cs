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
    public class CartRepository : ICartRepository
    {
        private readonly IDbContext dbContext;

        public CartRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Cart> GetAllCarts()
        {
            IEnumerable<Cart> result = dbContext.Connection.Query<Cart>("Cart_Package.GetAllCarts", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Cart GetCartById(int cartId)
        {
            var p = new DynamicParameters();
            p.Add("p_CartID", cartId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Cart>("Cart_Package.GetCartById", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public void CreateCart(Cart cart)
        {
            var p = new DynamicParameters();
            p.Add("p_Quantity", cart.Quantity, DbType.Int32, ParameterDirection.Input);
            p.Add("p_Total", cart.Total, DbType.Decimal, ParameterDirection.Input);
            p.Add("p_ConsumerID", cart.Consumerid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_ProductID", cart.Productid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_OrderID", cart.Orderid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_StoreID", cart.Storeid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Cart_Package.CreateCart", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateCart(Cart cart)
        {
            var p = new DynamicParameters();
            p.Add("p_CartID", cart.Cartid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_Quantity", cart.Quantity, DbType.Int32, ParameterDirection.Input);
            p.Add("p_Total", cart.Total, DbType.Decimal, ParameterDirection.Input);
            p.Add("p_ConsumerID", cart.Consumerid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_ProductID", cart.Productid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_OrderID", cart.Orderid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_StoreID", cart.Storeid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Cart_Package.UpdateCart", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteCart(int cartId)
        {
            var p = new DynamicParameters();
            p.Add("p_CartID", cartId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Cart_Package.DeleteCart", p, commandType: CommandType.StoredProcedure);
        }

        public List <ConsumerCart> GetCartMerchandiseByConsumerID(int consumerId)
        {
            var p = new DynamicParameters();
            p.Add("p_ConsumerID", consumerId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.Query<ConsumerCart>("GetCartMerchandiseByConsumerID", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<ConsumerCart> GetMerchandiseInCartByStoreID(int storeid, int consumerId)
        {
            var p = new DynamicParameters();
            p.Add("p_StoreID", storeid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_ConsumerID", consumerId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.Query<ConsumerCart>("GetMerchandiseInCartByStoreID", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
