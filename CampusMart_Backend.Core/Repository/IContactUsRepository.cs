using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Repository
{
    public interface IContactUsRepository
    {
       List<Contactu> GetAllContacts();
        Contactu GetContactById(int contactId);
        void CreateContact(Contactu contact);
        void UpdateContact(Contactu contact);
        void DeleteContact(int contactId);
    }
}
