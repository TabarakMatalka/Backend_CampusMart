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
    public class CampusServiceProviderRepository : ICampusServiceProviderRepository
    {
        private readonly IDbContext dbContext;

        public CampusServiceProviderRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }
        public List<Campusserviceprovider> GetAllServiceProviders()
        {
            IEnumerable<Campusserviceprovider> result = dbContext.Connection.Query<Campusserviceprovider>("CampusServiceProvider_Package.GetAllServiceProviders", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Campusserviceprovider GetServiceProviderById(int providerId)
        {
            var p = new DynamicParameters();
            p.Add("provider_id_param", providerId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Campusserviceprovider>("CampusServiceProvider_Package.GetServiceProviderById", p, commandType: CommandType.StoredProcedure);

            return result;
        }

        public void CreateServiceProvider(Campusserviceprovider provider)
        {
            var p = new DynamicParameters();
            p.Add("phone_param", provider.Phone, DbType.String, ParameterDirection.Input);
            p.Add("user_id_param", provider.Userid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("CampusServiceProvider_Package.CreateServiceProvider", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateServiceProvider(Campusserviceprovider provider)
        {
            var p = new DynamicParameters();
            p.Add("provider_id_param", provider.Providerid, DbType.Int32, ParameterDirection.Input);
            p.Add("phone_param", provider.Phone, DbType.String, ParameterDirection.Input);
            p.Add("user_id_param", provider.Userid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("CampusServiceProvider_Package.UpdateServiceProvider", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteServiceProvider(int providerId)
        {
            var p = new DynamicParameters();
            p.Add("provider_id_param", providerId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("CampusServiceProvider_Package.DeleteServiceProvider", p, commandType: CommandType.StoredProcedure);
        }
    }
}
