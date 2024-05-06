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
    public class LoginRepository : ILoginRepository
    {
        private readonly IDbContext dbContext;

        public LoginRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Login> GetAllLogins()
        {
            IEnumerable<Login> result = dbContext.Connection.Query<Login>("Login_Package.GetAllLogins", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Login GetLoginById(int loginId)
        {
            var p = new DynamicParameters();
            p.Add("login_Id", loginId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Login>("Login_Package.GetLoginById", p, commandType: CommandType.StoredProcedure);

            return result;
        }

        public void CreateLogin(Login login)
        {
            var p = new DynamicParameters();
            p.Add("login_username", login.Username, DbType.String, ParameterDirection.Input);
            p.Add("login_password", login.Password, DbType.String, ParameterDirection.Input);
            p.Add("login_ConsumerID", login.Consumerid, DbType.Int32, ParameterDirection.Input);
            p.Add("login_RoleID", login.Roleid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Login_Package.Create_Login", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateLogin(Login login)
        {
            var p = new DynamicParameters();
            p.Add("login_Id", login.Id, DbType.Int32, ParameterDirection.Input);
            p.Add("login_username", login.Username, DbType.String, ParameterDirection.Input);
            p.Add("login_password", login.Password, DbType.String, ParameterDirection.Input);
            p.Add("login_ConsumerID", login.Consumerid, DbType.Int32, ParameterDirection.Input);
            p.Add("login_RoleID", login.Roleid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Login_Package.Update_Login", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteLogin(int loginId)
        {
            var p = new DynamicParameters();
            p.Add("login_Id", loginId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Login_Package.DeleteLogin", p, commandType: CommandType.StoredProcedure);
        }
        public Login Auth(Login login)
        {
            var p = new DynamicParameters();
            p.Add("User_NAME", login.Username, DbType.String, ParameterDirection.Input);
            p.Add("PASS", login.Password, DbType.String, ParameterDirection.Input);

            Login result = dbContext.Connection.QueryFirstOrDefault<Login>("Login_Package.User_Login", p, commandType: CommandType.StoredProcedure);

            return result;
        }
    }
}
