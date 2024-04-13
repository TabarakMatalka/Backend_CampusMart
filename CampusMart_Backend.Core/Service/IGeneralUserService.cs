using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Service
{
    public interface IGeneralUserService
    {
       List<Generaluser> GetAllUsers();
        Generaluser GetUserById(int id);
        void CreateUser(Generaluser user);
        void UpdateUser(Generaluser user);
        void DeleteUser(int id);
    }
}
