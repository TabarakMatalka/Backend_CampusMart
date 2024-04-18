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
    public class CampusConsumerRepository : ICampusConsumerRepository
    
        {
        private readonly IDbContext dbContext;

        public CampusConsumerRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Campusconsumer> GetAllConsumers()
        {
            // Execute stored procedure to get all consumers
            IEnumerable<Campusconsumer> result = dbContext.Connection.Query<Campusconsumer>("CampusConsumer_Package.GetAllConsumers", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Campusconsumer GetConsumerById(int consumerId)
        {
            // Execute stored procedure to get consumer by ID
            var p = new DynamicParameters();
            p.Add("id", consumerId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Campusconsumer>("CampusConsumer_Package.GetConsumerById", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public void CreateConsumer(Campusconsumer consumer)
        {
            // Execute stored procedure to create a new consumer
            var p = new DynamicParameters();
            p.Add("p_IsProvider", consumer.Isprovider, DbType.Int32, ParameterDirection.Input);
            p.Add("p_LOCATION_LATITUDE", consumer.LocationLatitude, DbType.String, ParameterDirection.Input);
            p.Add("p_LOCATION_LONGITUDE", consumer.LocationLongitude, DbType.String, ParameterDirection.Input);
            p.Add("p_FullName", consumer.Fullname, DbType.String, ParameterDirection.Input);
            p.Add("p_Email", consumer.Email, DbType.String, ParameterDirection.Input);
            p.Add("p_Imagepath", consumer.Imagepath, DbType.String, ParameterDirection.Input);
            p.Add("p_Phone", consumer.Phone, DbType.String, ParameterDirection.Input);
            p.Add("p_Status", consumer.Status, DbType.String, ParameterDirection.Input);
            p.Add("p_Password", consumer.Password, DbType.String, ParameterDirection.Input);
            p.Add("p_RoleID", consumer.Roleid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("CampusConsumer_Package.CreateConsumer", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateConsumer(Campusconsumer consumer)
        {
            // Execute stored procedure to update an existing consumer
            var p = new DynamicParameters();
            p.Add("p_ConsumerID", consumer.Consumerid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_IsProvider", consumer.Isprovider, DbType.Int32, ParameterDirection.Input);
            p.Add("p_LOCATION_LATITUDE", consumer.LocationLatitude, DbType.String, ParameterDirection.Input);
            p.Add("p_LOCATION_LONGITUDE", consumer.LocationLongitude, DbType.String, ParameterDirection.Input);
            p.Add("p_FullName", consumer.Fullname, DbType.String, ParameterDirection.Input);
            p.Add("p_Email", consumer.Email, DbType.String, ParameterDirection.Input);
            p.Add("p_Imagepath", consumer.Imagepath, DbType.String, ParameterDirection.Input);
            p.Add("p_Phone", consumer.Phone, DbType.String, ParameterDirection.Input);
            p.Add("p_Status", consumer.Status, DbType.String, ParameterDirection.Input);
            p.Add("p_Password", consumer.Password, DbType.String, ParameterDirection.Input);
            p.Add("p_RoleID", consumer.Roleid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("CampusConsumer_Package.UpdateConsumer", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteConsumer(int consumerId)
        {
            // Execute stored procedure to delete a consumer by ID
            var p = new DynamicParameters();
            p.Add("id", consumerId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("CampusConsumer_Package.DeleteConsumer", p, commandType: CommandType.StoredProcedure);
        }
    }

    }