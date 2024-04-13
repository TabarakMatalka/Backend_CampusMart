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
            IEnumerable<Role> result = dbContext.Connection.Query<Role>("Roles_Package.GetAllRoles", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Role GetRoleById(int id)
        {
            var p = new DynamicParameters();
            p.Add("p_id", id, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.Query<Role>("Roles_Package.GetRoleById", p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public void CreateRole(Role role)
        {
            var p = new DynamicParameters();
            p.Add("p_RoleName", role.RoleName, DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("Roles_Package.Create_Role", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateRole(Role role)
        {
            var p = new DynamicParameters();
            p.Add("p_ID", role.RoleId, DbType.Int32, ParameterDirection.Input);
            p.Add("p_RoleName", role.RoleName, DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("Roles_Package.Update_Role", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteRole(int id)
        {
            var p = new DynamicParameters();
            p.Add("p_id", id, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Roles_Package.DeleteRole", p, commandType: CommandType.StoredProcedure);
        }
    }
}
