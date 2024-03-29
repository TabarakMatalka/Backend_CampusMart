using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Repository;
using CampusMart_Backend.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Infra.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        public void CreateRole(Role role)
        {
            this.roleRepository.CreateRole(role);
        }

        public void DeleteRole(int id)
        {
            this.roleRepository.DeleteRole(id);
        }

        public List<Role> GetAllRoles()
        {
            return this.roleRepository.GetAllRoles();
        }

        public Role GetRoleByID(int id)
        {
            return this.roleRepository.GetRoleByID(id);
        }

        public void UpdateRole(Role role)
        {
            this.roleRepository.UpdateRole(role);
        }
    }
}
