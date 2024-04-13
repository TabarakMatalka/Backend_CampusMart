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
    public class CampusConsumerRepository : ICampusConsumerRepository
    
        {
            private readonly IDbContext dbContext;

            public CampusConsumerRepository(IDbContext _dbContext)
            {
                this.dbContext = _dbContext;
            }

            public List<Campusconsumer> GetAllConsumers()
            {
                IEnumerable<Campusconsumer> result = dbContext.Connection.Query<Campusconsumer>("CampusConsumer_Package.GetAllConsumers", commandType: CommandType.StoredProcedure);
                return result.ToList();
            }

            public Campusconsumer GetConsumerById(int consumerId)
            {
                var p = new DynamicParameters();
                p.Add("id", consumerId, DbType.Int32, ParameterDirection.Input);
                var result = dbContext.Connection.QueryFirstOrDefault<Campusconsumer>("CampusConsumer_Package.GetConsumerById", p, commandType: CommandType.StoredProcedure);
                return result;
            }

            public void CreateConsumer(Campusconsumer consumer)
            {
                var p = new DynamicParameters();
                p.Add("p_Phone", consumer.Phone, DbType.String, ParameterDirection.Input);
                p.Add("p_IsProvider", consumer.Isprovider, DbType.Int32, ParameterDirection.Input);
                p.Add("p_LOCATION_LATITUDE", consumer.LocationLatitude, DbType.String, ParameterDirection.Input);
                p.Add("p_LOCATION_LONGITUDE", consumer.LocationLongitude, DbType.String, ParameterDirection.Input);
                p.Add("p_UserID", consumer.Userid, DbType.Int32, ParameterDirection.Input);
                dbContext.Connection.Execute("CampusConsumer_Package.CreateConsumer", p, commandType: CommandType.StoredProcedure);
            }

            public void UpdateConsumer(Campusconsumer consumer)
            {
                var p = new DynamicParameters();
                p.Add("p_ConsumerID", consumer.Consumerid, DbType.Int32, ParameterDirection.Input);
                p.Add("p_Phone", consumer.Phone, DbType.String, ParameterDirection.Input);
                p.Add("p_IsProvider", consumer.Isprovider, DbType.Int32, ParameterDirection.Input);
                p.Add("p_LOCATION_LATITUDE", consumer.LocationLatitude, DbType.String, ParameterDirection.Input);
                p.Add("p_LOCATION_LONGITUDE", consumer.LocationLongitude, DbType.String, ParameterDirection.Input);
                p.Add("p_UserID", consumer.Userid, DbType.Int32, ParameterDirection.Input);
                dbContext.Connection.Execute("CampusConsumer_Package.UpdateConsumer", p, commandType: CommandType.StoredProcedure);
            }

            public void DeleteConsumer(int consumerId)
            {
                var p = new DynamicParameters();
                p.Add("id", consumerId, DbType.Int32, ParameterDirection.Input);
                dbContext.Connection.Execute("CampusConsumer_Package.DeleteConsumer", p, commandType: CommandType.StoredProcedure);
            }
        }

    }