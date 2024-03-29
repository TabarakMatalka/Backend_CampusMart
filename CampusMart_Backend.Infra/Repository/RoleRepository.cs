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

    public class RoleRepository : IRoleRepository
    {
        private readonly IDbContext dbContext;

        public RoleRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Role> GetAllRoles()
        {
            IEnumerable<Role> result = dbContext.Connection.Query<Role>("Role_Package.GetAllRoles", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Role GetRoleByID(int id)
        {
            var p = new DynamicParameters();
            p.Add("role_id", id, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.Query<Role>("Role_Package.GetRoleById", p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public void CreateRole(Role role)
        {
            var p = new DynamicParameters();
            p.Add("role_name_param", role.Rolename, DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("Role_Package.CreateRole", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateRole(Role role)
        {
            var p = new DynamicParameters();
            p.Add("role_id_param", role.Roleid, DbType.Int32, ParameterDirection.Input);
            p.Add("role_name_param", role.Rolename, DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("Role_Package.UpdateRole", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteRole(int id)
        {
            var p = new DynamicParameters();
            p.Add("role_id_param", id, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Role_Package.DeleteRole", p, commandType: CommandType.StoredProcedure);
        }
    }
}
