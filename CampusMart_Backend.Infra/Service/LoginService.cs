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
    }
}
