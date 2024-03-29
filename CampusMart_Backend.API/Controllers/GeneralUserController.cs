using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralUserController : ControllerBase
    {
        private readonly IGeneralUserService generalUserService;

        public GeneralUserController(IGeneralUserService generalUserService)
        {
            this.generalUserService = generalUserService;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public List<Generaluser> GetAllUsers()
        {
            return generalUserService.GetAllUsers();
        }

        [HttpGet]
        [Route("GetUserById/{id}")]
        public Generaluser GetUserById(int id)
        {
            return generalUserService.GetUserById(id);
        }

        [HttpPost]
        [Route("CreateUser")]
        public void CreateUser(Generaluser user)
        {
            generalUserService.CreateUser(user);
        }

        [HttpPut]
        [Route("UpdateUser")]
        public void UpdateUser(Generaluser user)
        {
            generalUserService.UpdateUser(user);
        }

        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public void DeleteUser(int id)
        {
            generalUserService.DeleteUser(id);
        }
    }
}
