using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService loginService;

        public LoginController(ILoginService loginService)
        {
            this.loginService = loginService;
        }

        [HttpGet]
        [Route("GetAllLogins")]
        public List<Login> GetAllLogins()
        {
            return loginService.GetAllLogins();
        }

        [HttpGet]
        [Route("GetLoginById/{id}")]
        public Login GetLoginById(int id)
        {
            return loginService.GetLoginById(id);
        }

        [HttpPost]
        [Route("CreateLogin")]
        public void CreateLogin(Login login)
        {
            loginService.CreateLogin(login);
        }

        [HttpPut]
        [Route("UpdateLogin")]
        public void UpdateLogin(Login login)
        {
            loginService.UpdateLogin(login);
        }

        [HttpDelete]
        [Route("DeleteLogin/{id}")]
        public void DeleteLogin(int id)
        {
            loginService.DeleteLogin(id);
        }
        [HttpPost]
        [Route("Auth")]
        public IActionResult Auth([FromBody] Login login)
        {
            var token = loginService.Auth(login);
            if (token == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(token);
            }
        }
    }
}
