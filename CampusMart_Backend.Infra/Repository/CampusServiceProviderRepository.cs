﻿using CampusMart_Backend.Core.Common;
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
             p.Add("p_ProviderID", providerId, DbType.Int32, ParameterDirection.Input);
             var result = dbContext.Connection.QueryFirstOrDefault<Campusserviceprovider>("CampusServiceProvider_Package.GetServiceProviderById", p, commandType: CommandType.StoredProcedure);
             return result;
         }

         public void CreateServiceProvider(Campusserviceprovider serviceProvider)
 {
     var p = new DynamicParameters();
     p.Add("p_Phone", serviceProvider.Phone, DbType.String, ParameterDirection.Input);
     p.Add("p_LOCATION_LATITUDE", serviceProvider.LocationLatitude, DbType.String, ParameterDirection.Input);
     p.Add("p_LOCATION_LONGITUDE", serviceProvider.LocationLongitude, DbType.String, ParameterDirection.Input);
     p.Add("c_ConsumerID", serviceProvider.Consumerid, DbType.Int32, ParameterDirection.Input);
     p.Add("p_Motivation", serviceProvider.Motivation, DbType.String, ParameterDirection.Input); 
     p.Add("p_Status", serviceProvider.Status, DbType.String, ParameterDirection.Input); 
     dbContext.Connection.Execute("CampusServiceProvider_Package.CreateServiceProvider", p, commandType: CommandType.StoredProcedure);
 }

 public void UpdateServiceProvider(Campusserviceprovider serviceProvider)
 {
     var p = new DynamicParameters();
     p.Add("p_ProviderID", serviceProvider.Providerid, DbType.Int32, ParameterDirection.Input);
     p.Add("p_Phone", serviceProvider.Phone, DbType.String, ParameterDirection.Input);
     p.Add("p_LOCATION_LATITUDE", serviceProvider.LocationLatitude, DbType.String, ParameterDirection.Input);
     p.Add("p_LOCATION_LONGITUDE", serviceProvider.LocationLongitude, DbType.String, ParameterDirection.Input);
     p.Add("c_ConsumerID", serviceProvider.Consumerid, DbType.Int32, ParameterDirection.Input);
     p.Add("p_Motivation", serviceProvider.Motivation, DbType.String, ParameterDirection.Input); // Assuming Motivation is a property in CampusServiceProvider
     p.Add("p_Status", serviceProvider.Status, DbType.String, ParameterDirection.Input); // Assuming Status is a property in CampusServiceProvider
     dbContext.Connection.Execute("CampusServiceProvider_Package.UpdateServiceProvider", p, commandType: CommandType.StoredProcedure);
 }


         public void DeleteServiceProvider(int providerId)
         {
             var p = new DynamicParameters();
             p.Add("p_ProviderID", providerId, DbType.Int32, ParameterDirection.Input);
             dbContext.Connection.Execute("CampusServiceProvider_Package.DeleteServiceProvider", p, commandType: CommandType.StoredProcedure);
         }
    }
}
