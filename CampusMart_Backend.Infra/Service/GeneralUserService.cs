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
    public class GeneralUserService : IGeneralUserService
    {
        private readonly IGeneralUserRepository generalUserRepository;

        public GeneralUserService(IGeneralUserRepository generalUserRepository)
        {
            this.generalUserRepository = generalUserRepository;
        }

        public void CreateUser(Generaluser user)
        {
            this.generalUserRepository.CreateUser(user);
        }

        public void DeleteUser(int id)
        {
            this.generalUserRepository.DeleteUser(id);
        }

        public List<Generaluser> GetAllUsers()
        {
            return this.generalUserRepository.GetAllUsers();
        }

        public Generaluser GetUserById(int id)
        {
            return this.generalUserRepository.GetUserById(id);
        }

        public void UpdateUser(Generaluser user)
        {
            this.generalUserRepository.UpdateUser(user);
        }
    }
}
