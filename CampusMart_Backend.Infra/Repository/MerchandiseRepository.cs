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
            p.Add("m_ProductID", merchandiseId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Merchandise>("Merchandise_Package.GetMerchandiseById", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public void CreateMerchandise(Merchandise merchandise)
        {
            var p = new DynamicParameters();
            p.Add("m_Name", merchandise.Name, DbType.String, ParameterDirection.Input);
            p.Add("m_Rate", merchandise.Rate, DbType.Decimal, ParameterDirection.Input);
            p.Add("m_Description", merchandise.Description, DbType.String, ParameterDirection.Input);
            p.Add("m_Category", merchandise.Category, DbType.String, ParameterDirection.Input);
            p.Add("m_Price", merchandise.Price, DbType.Decimal, ParameterDirection.Input);
            p.Add("m_Quantity", merchandise.Quantity, DbType.Int32, ParameterDirection.Input);
            p.Add("m_Image", merchandise.Image, DbType.String, ParameterDirection.Input);
            p.Add("m_Status", merchandise.Status, DbType.String, ParameterDirection.Input);
            p.Add("m_StoreID", merchandise.Storeid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Merchandise_Package.Create_Merchandise", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateMerchandise(Merchandise merchandise)
        {
            var p = new DynamicParameters();
            p.Add("m_ProductID", merchandise.Productid, DbType.Int32, ParameterDirection.Input);
            p.Add("m_Name", merchandise.Name, DbType.String, ParameterDirection.Input);
            p.Add("m_Rate", merchandise.Rate, DbType.Decimal, ParameterDirection.Input);
            p.Add("m_Description", merchandise.Description, DbType.String, ParameterDirection.Input);
            p.Add("m_Category", merchandise.Category, DbType.String, ParameterDirection.Input);
            p.Add("m_Price", merchandise.Price, DbType.Decimal, ParameterDirection.Input);
            p.Add("m_Quantity", merchandise.Quantity, DbType.Int32, ParameterDirection.Input);
            p.Add("m_Image", merchandise.Image, DbType.String, ParameterDirection.Input);
            p.Add("m_Status", merchandise.Status, DbType.String, ParameterDirection.Input);
            p.Add("m_StoreID", merchandise.Storeid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Merchandise_Package.Update_Merchandise", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteMerchandise(int merchandiseId)
        {
            var p = new DynamicParameters();
            p.Add("m_ProductID", merchandiseId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Merchandise_Package.DeleteMerchandise", p, commandType: CommandType.StoredProcedure);
        }


        public List<Merchandise> GetAllPendingMerchandise()
        {
            IEnumerable<Merchandise> result = dbContext.Connection.Query<Merchandise>("Merchandise_Package.GetAllPendingMerchandise", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public void UpdateMerchandiseRequestStatus(int merchandiseId, string newStatus)
        {
            var p = new DynamicParameters();
            p.Add("merchandise_id_param", merchandiseId, DbType.Int32, ParameterDirection.Input);
            p.Add("new_status_param", newStatus, DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("Merchandise_Package.UpdateMerchandiseRequestStatus", p, commandType: CommandType.StoredProcedure);
        }


    }

}
