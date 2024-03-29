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
    public class MerchandiseReviewRepository : IMerchandiseReviewRepository
    {
        private readonly IDbContext dbContext;

        public MerchandiseReviewRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<MerchandiseReview> GetAllMerchandiseReviews()
        {
            IEnumerable<MerchandiseReview> result = dbContext.Connection.Query<MerchandiseReview>("MerchandiseReview_Package.GetAllMerchandiseReviews", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public MerchandiseReview GetMerchandiseReviewById(int merchandiseReviewId)
        {
            var p = new DynamicParameters();
            p.Add("mr_MerchandiseReviewID", merchandiseReviewId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<MerchandiseReview>("MerchandiseReview_Package.GetMerchandiseReviewById", p, commandType: CommandType.StoredProcedure);

            return result;
        }

        public void CreateMerchandiseReview(MerchandiseReview merchandiseReview)
        {
            var p = new DynamicParameters();
            p.Add("mr_ConsumerID", merchandiseReview.Consumerid, DbType.Int32, ParameterDirection.Input);
            p.Add("mr_ProductID", merchandiseReview.Productid, DbType.Int32, ParameterDirection.Input);
            p.Add("mr_OrderID", merchandiseReview.Orderid, DbType.Int32, ParameterDirection.Input);
            p.Add("mr_RATING", merchandiseReview.Rating, DbType.Int32, ParameterDirection.Input);
            p.Add("mr_REVIEW_TEXT", merchandiseReview.ReviewText, DbType.String, ParameterDirection.Input);
            p.Add("mr_REVIEW_DATE", merchandiseReview.ReviewDate, DbType.Date, ParameterDirection.Input);
            dbContext.Connection.Execute("MerchandiseReview_Package.Create_MerchandiseReview", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateMerchandiseReview(MerchandiseReview merchandiseReview)
        {
            var p = new DynamicParameters();
            p.Add("mr_MerchandiseReviewID", merchandiseReview.MerchandiseReviewId, DbType.Int32, ParameterDirection.Input);
            p.Add("mr_ConsumerID", merchandiseReview.Consumerid, DbType.Int32, ParameterDirection.Input);
            p.Add("mr_ProductID", merchandiseReview.Productid, DbType.Int32, ParameterDirection.Input);
            p.Add("mr_OrderID", merchandiseReview.Orderid, DbType.Int32, ParameterDirection.Input);
            p.Add("mr_RATING", merchandiseReview.Rating, DbType.Int32, ParameterDirection.Input);
            p.Add("mr_REVIEW_TEXT", merchandiseReview.ReviewText, DbType.String, ParameterDirection.Input);
            p.Add("mr_REVIEW_DATE", merchandiseReview.ReviewDate, DbType.Date, ParameterDirection.Input);
            dbContext.Connection.Execute("MerchandiseReview_Package.Update_MerchandiseReview", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteMerchandiseReview(int merchandiseReviewId)
        {
            var p = new DynamicParameters();
            p.Add("mr_MerchandiseReviewID", merchandiseReviewId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("MerchandiseReview_Package.DeleteMerchandiseReview", p, commandType: CommandType.StoredProcedure);
        }
    }
}
