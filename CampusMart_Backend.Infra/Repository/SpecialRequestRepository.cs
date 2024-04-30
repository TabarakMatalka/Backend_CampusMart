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
    public class SpecialRequestRepository : ISpecialRequestRepository
    {
       private readonly IDbContext dbContext;

        public SpecialRequestRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Specialrequest> GetAllRequests()
        {
            IEnumerable<Specialrequest> result = dbContext.Connection.Query<Specialrequest>("SpecialRequest_Package.GetAllRequests", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Specialrequest GetRequestById(int requestId)
        {
            var p = new DynamicParameters();
            p.Add("request_id_param", requestId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Specialrequest>("SpecialRequest_Package.GetRequestById", p, commandType: CommandType.StoredProcedure);

            return result;
        }

        public void CreateRequest(Specialrequest request)
        {
            var p = new DynamicParameters();
            p.Add("title_param", request.Requesttitle, DbType.String, ParameterDirection.Input);
            p.Add("details_param", request.Requestdetails, DbType.String, ParameterDirection.Input);
            p.Add("status_param", request.Requeststatus, DbType.String, ParameterDirection.Input);
            p.Add("consumer_id_param", request.Consumerid, DbType.Int32, ParameterDirection.Input);
            p.Add("provider_id_param", request.Providerid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("SpecialRequest_Package.CreateRequest", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateRequest(Specialrequest request)
        {
            var p = new DynamicParameters();
            p.Add("request_id_param", request.Requestid, DbType.Int32, ParameterDirection.Input);
            p.Add("title_param", request.Requesttitle, DbType.String, ParameterDirection.Input);
            p.Add("details_param", request.Requestdetails, DbType.String, ParameterDirection.Input);
            p.Add("status_param", request.Requeststatus, DbType.String, ParameterDirection.Input);
            p.Add("consumer_id_param", request.Consumerid, DbType.Int32, ParameterDirection.Input);
            p.Add("provider_id_param", request.Providerid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("SpecialRequest_Package.UpdateRequest", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteRequest(int requestId)
        {
            var p = new DynamicParameters();
            p.Add("request_id_param", requestId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("SpecialRequest_Package.DeleteRequest", p, commandType: CommandType.StoredProcedure);
        }
    }
}
