using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Repository
{
    public interface ILoginRepository
    {
       List<Login> GetAllLogins();
        Login GetLoginById(int loginId);
        void CreateLogin(Login login);
        void UpdateLogin(Login login);
        void DeleteLogin(int loginId);

        Login Auth(Login login);
    }

}
