using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Repository;
using CampusMart_Backend.Core.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Infra.Service
{

    public class LoginService : ILoginService
    {
      private readonly ILoginRepository loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            this.loginRepository = loginRepository;
        }

        public void CreateLogin(Login login)
        {
            this.loginRepository.CreateLogin(login);
        }

        public void DeleteLogin(int loginId)
        {
            this.loginRepository.DeleteLogin(loginId);
        }

        public List<Login> GetAllLogins()
        {
            return this.loginRepository.GetAllLogins();
        }

        public Login GetLoginById(int loginId)
        {
            return this.loginRepository.GetLoginById(loginId);
        }

        public void UpdateLogin(Login login)
        {
            this.loginRepository.UpdateLogin(login);
        }

        public string Auth(Login login)
        {
            var result = loginRepository.Auth(login);
            if (result == null)
            {
                return null;
            }
            else
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var claims = new List<Claim>
                {
                        new Claim("login_username", result.Username.ToString()),
                        new Claim("login_RoleID", result.Roleid.ToString()),
                        new Claim("login_ConsumerID", result.Consumerid.ToString())
                };
                var tokeOptions = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddHours(24), signingCredentials: signinCredentials);
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return tokenString;
            }
        }
    }
}
