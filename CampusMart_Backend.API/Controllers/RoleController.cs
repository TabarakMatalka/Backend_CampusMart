using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
       private readonly IRoleService roleService;

        public RoleController(IRoleService roleService)
        {
            this.roleService = roleService;
        }

        [HttpGet]
        [Route("GetAllRoles")]
        public List<Role> GetAllRoles()
        {
            return roleService.GetAllRoles();
        }

        [HttpGet]
        [Route("GetRoleByID/{id}")]
        public Role GetRoleByID(int id)
        {
            return roleService.GetRoleByID(id);
        }

        [HttpPost]
        [Route("CreateRole")]
        public void CreateRole(Role role)
        {
            roleService.CreateRole(role);
        }

        [HttpPut]
        [Route("UpdateRole")]
        public void UpdateRole(Role role)
        {
            roleService.UpdateRole(role);
        }

        [HttpDelete]
        [Route("DeleteRole/{id}")]
        public void DeleteRole(int id)
        {
            roleService.DeleteRole(id);
        }
    }
}
