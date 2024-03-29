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
    public class StoreReviewRepository : IStoreReviewRepository
    {
        private readonly IDbContext dbContext;

        public StoreReviewRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<StoreReview> GetAllStoreReviews()
        {
            IEnumerable<StoreReview> result = dbContext.Connection.Query<StoreReview>("StoreReview_Package.GetAllStoreReviews", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public StoreReview GetStoreReviewById(int storeReviewId)
        {
            var p = new DynamicParameters();
            p.Add("sr_StoreReviewID", storeReviewId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<StoreReview>("StoreReview_Package.GetStoreReviewById", p, commandType: CommandType.StoredProcedure);

            return result;
        }

        public void CreateStoreReview(StoreReview storeReview)
        {
            var p = new DynamicParameters();
            p.Add("sr_ConsumerID", storeReview.Consumerid, DbType.Int32, ParameterDirection.Input);
            p.Add("sr_StoreID", storeReview.Storeid, DbType.Int32, ParameterDirection.Input);
            p.Add("sr_OrderID", storeReview.Orderid, DbType.Int32, ParameterDirection.Input);
            p.Add("sr_RATING", storeReview.Rating, DbType.Int32, ParameterDirection.Input);
            p.Add("sr_REVIEW_TEXT", storeReview.ReviewText, DbType.String, ParameterDirection.Input);
            p.Add("sr_REVIEW_DATE", storeReview.ReviewDate, DbType.Date, ParameterDirection.Input);
            dbContext.Connection.Execute("StoreReview_Package.Create_StoreReview", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateStoreReview(StoreReview storeReview)
        {
            var p = new DynamicParameters();
            p.Add("sr_StoreReviewID", storeReview.StoreReviewId, DbType.Int32, ParameterDirection.Input);
            p.Add("sr_ConsumerID", storeReview.Consumerid, DbType.Int32, ParameterDirection.Input);
            p.Add("sr_StoreID", storeReview.Storeid, DbType.Int32, ParameterDirection.Input);
            p.Add("sr_OrderID", storeReview.Orderid, DbType.Int32, ParameterDirection.Input);
            p.Add("sr_RATING", storeReview.Rating, DbType.Int32, ParameterDirection.Input);
            p.Add("sr_REVIEW_TEXT", storeReview.ReviewText, DbType.String, ParameterDirection.Input);
            p.Add("sr_REVIEW_DATE", storeReview.ReviewDate, DbType.Date, ParameterDirection.Input);
            dbContext.Connection.Execute("StoreReview_Package.Update_StoreReview", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteStoreReview(int storeReviewId)
        {
            var p = new DynamicParameters();
            p.Add("sr_StoreReviewID", storeReviewId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("StoreReview_Package.DeleteStoreReview", p, commandType: CommandType.StoredProcedure);
        }
    }
}
