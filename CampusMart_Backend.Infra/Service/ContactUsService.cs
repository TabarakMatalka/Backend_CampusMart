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
    public class ContactUsService : IContactUsService
    {
        private readonly IContactUsRepository contactUsRepository;

        public ContactUsService(IContactUsRepository contactUsRepository)
        {
            this.contactUsRepository = contactUsRepository;
        }

        public void CreateContact(Contactu contact)
        {
            this.contactUsRepository.CreateContact(contact);
        }

        public void DeleteContact(int contactId)
        {
            this.contactUsRepository.DeleteContact(contactId);
        }

        public List<Contactu> GetAllContacts()
        {
            return this.contactUsRepository.GetAllContacts();
        }

        public Contactu GetContactById(int contactId)
        {
            return this.contactUsRepository.GetContactById(contactId);
        }

        public void UpdateContact(Contactu contact)
        {
            this.contactUsRepository.UpdateContact(contact);
        }
    }

}
