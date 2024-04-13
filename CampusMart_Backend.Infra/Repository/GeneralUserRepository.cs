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

    public class GeneralUserRepository : IGeneralUserRepository
    {
       private readonly IDbContext dbContext;

        public GeneralUserRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Generaluser> GetAllUsers()
        {
            IEnumerable<Generaluser> result = dbContext.Connection.Query<Generaluser>("GeneralUsers_Package.GetAllUsers", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Generaluser GetUserById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Generaluser>("GeneralUsers_Package.GetUserById", p, commandType: CommandType.StoredProcedure);

            return result;
        }

        public void CreateUser(Generaluser user)
        {
            var p = new DynamicParameters();
            p.Add("FName", user.Fullname, DbType.String, ParameterDirection.Input);
            p.Add("Eml", user.Email, DbType.String, ParameterDirection.Input);
            p.Add("ImgPath", user.Imagepath, DbType.String, ParameterDirection.Input);
            p.Add("Phn", user.Phone, DbType.String, ParameterDirection.Input);
            p.Add("Stat", user.Status, DbType.String, ParameterDirection.Input);
            p.Add("PWD", user.Password, DbType.String, ParameterDirection.Input);
            p.Add("R_ID", user.Roleid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("GeneralUsers_Package.Create_User", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateUser(Generaluser user)
        {
            var p = new DynamicParameters();
            p.Add("ID", user.Userid, DbType.Int32, ParameterDirection.Input);
            p.Add("FName", user.Fullname, DbType.String, ParameterDirection.Input);
            p.Add("Eml", user.Email, DbType.String, ParameterDirection.Input);
            p.Add("ImgPath", user.Imagepath, DbType.String, ParameterDirection.Input);
            p.Add("Phn", user.Phone, DbType.String, ParameterDirection.Input);
            p.Add("Stat", user.Status, DbType.String, ParameterDirection.Input);
            p.Add("PWD", user.Password, DbType.String, ParameterDirection.Input);
            p.Add("R_ID", user.Roleid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("GeneralUsers_Package.Update_User", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("GeneralUsers_Package.DeleteUser", p, commandType: CommandType.StoredProcedure);
        }
    }
}
