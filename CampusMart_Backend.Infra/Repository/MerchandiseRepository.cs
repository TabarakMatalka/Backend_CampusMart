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
    public class MerchandiseRepository : IMerchandiseRepository
    {
        private readonly IDbContext dbContext;

        public MerchandiseRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Merchandise> GetAllMerchandise()
        {
            IEnumerable<Merchandise> result = dbContext.Connection.Query<Merchandise>("Merchandise_Package.GetAllMerchandise", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Merchandise GetMerchandiseById(int merchandiseId)
        {
            var p = new DynamicParameters();
            p.Add("merchandise_id", merchandiseId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Merchandise>("Merchandise_Package.GetMerchandiseById", p, commandType: CommandType.StoredProcedure);

            return result;
        }

        public void CreateMerchandise(Merchandise merchandise)
        {
            var p = new DynamicParameters();
            p.Add("merchandise_ProductName", merchandise.Name, DbType.String, ParameterDirection.Input);
            p.Add("merchandise_Rate", merchandise.Rate, DbType.Decimal, ParameterDirection.Input);
            p.Add("merchandise_Description", merchandise.Description, DbType.String, ParameterDirection.Input);
            p.Add("merchandise_Category", merchandise.Category, DbType.String, ParameterDirection.Input);
            p.Add("merchandise_Price", merchandise.Price, DbType.Decimal, ParameterDirection.Input);
            p.Add("merchandise_Quantity", merchandise.Quantity, DbType.Int32, ParameterDirection.Input);
            p.Add("merchandise_ImagePath", merchandise.Image, DbType.String, ParameterDirection.Input);
            p.Add("merchandise_StoreID", merchandise.Storeid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Merchandise_Package.Create_Merchandise", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateMerchandise(Merchandise merchandise)
        {
            var p = new DynamicParameters();
            p.Add("merchandise_ProductID", merchandise.Productid, DbType.Int32, ParameterDirection.Input);
            p.Add("merchandise_ProductName", merchandise.Name, DbType.String, ParameterDirection.Input);
            p.Add("merchandise_Rate", merchandise.Rate, DbType.Decimal, ParameterDirection.Input);
            p.Add("merchandise_Description", merchandise.Description, DbType.String, ParameterDirection.Input);
            p.Add("merchandise_Category", merchandise.Category, DbType.String, ParameterDirection.Input);
            p.Add("merchandise_Price", merchandise.Price, DbType.Decimal, ParameterDirection.Input);
            p.Add("merchandise_Quantity", merchandise.Quantity, DbType.Int32, ParameterDirection.Input);
            p.Add("merchandise_ImagePath", merchandise.Image, DbType.String, ParameterDirection.Input);
            p.Add("merchandise_StoreID", merchandise.Storeid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Merchandise_Package.Update_Merchandise", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteMerchandise(int merchandiseId)
        {
            var p = new DynamicParameters();
            p.Add("merchandise_ProductID", merchandiseId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Merchandise_Package.DeleteMerchandise", p, commandType: CommandType.StoredProcedure);
        }
    }

}
