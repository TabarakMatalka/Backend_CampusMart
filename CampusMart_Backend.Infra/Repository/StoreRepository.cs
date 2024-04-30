using CampusMart_Backend.Core.Common;
using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Repository;
using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Infra.Repository
{
    public class StoreRepository : IStoreRepository
    {
       private readonly IDbContext dbContext;

        public StoreRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Store> GetAllStores()
        {
            IEnumerable<Store> result = dbContext.Connection.Query<Store>("Store_Package.GetAllStores", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Store GetStoreById(int storeId)
        {
            var p = new DynamicParameters();
            p.Add("store_id_param", storeId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Store>("Store_Package.GetStoreById", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public void CreateStore(Store store)
        {
            var p = new DynamicParameters();
            p.Add("store_name_param", store.Storename, DbType.String, ParameterDirection.Input);
            p.Add("is_open_param", store.Isopen, DbType.Int32, ParameterDirection.Input);
            p.Add("rate_param", store.Rate, DbType.Decimal, ParameterDirection.Input);
            p.Add("approval_status_param", store.Approvalstatus, DbType.String, ParameterDirection.Input);
            p.Add("image_param", store.Image, DbType.String, ParameterDirection.Input);
            p.Add("provider_id_param", store.Providerid, DbType.Int32, ParameterDirection.Input);
            p.Add("description_param", store.Description, DbType.String, ParameterDirection.Input); // Adding description parameter
            dbContext.Connection.Execute("Store_Package.Insert_Store", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateStore(Store store)
        {
            var p = new DynamicParameters();
            p.Add("store_id_param", store.Storeid, DbType.Int32, ParameterDirection.Input);
            p.Add("store_name_param", store.Storename, DbType.String, ParameterDirection.Input);
            p.Add("is_open_param", store.Isopen, DbType.Int32, ParameterDirection.Input);
            p.Add("rate_param", store.Rate, DbType.Decimal, ParameterDirection.Input);
            p.Add("approval_status_param", store.Approvalstatus, DbType.String, ParameterDirection.Input);
            p.Add("image_param", store.Image, DbType.String, ParameterDirection.Input);
            p.Add("provider_id_param", store.Providerid, DbType.Int32, ParameterDirection.Input);
            p.Add("description_param", store.Description, DbType.String, ParameterDirection.Input); // Adding description parameter
            dbContext.Connection.Execute("Store_Package.Update_Store", p, commandType: CommandType.StoredProcedure);
        }


        public void DeleteStore(int storeId)
        {
            var p = new DynamicParameters();
            p.Add("store_id_param", storeId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Store_Package.DeleteStore", p, commandType: CommandType.StoredProcedure);
        }

        public List<Store> GetAllStoresFromAllProviders()
        {

            IEnumerable<Store> result = dbContext.Connection.Query<Store>("GetAllStoresFromAllProviders", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
    }
}
