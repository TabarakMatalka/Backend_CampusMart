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
    public class ContactUsPageService : IContactUsPageService
    {
        private readonly IContactUsPageRepository contactUsPageRepository;

        public ContactUsPageService(IContactUsPageRepository contactUsPageRepository)
        {
            this.contactUsPageRepository = contactUsPageRepository;
        }

        public void CreateContactUsPage(Contactuspage contactUsPage)
        {
            this.contactUsPageRepository.CreateContactUsPage(contactUsPage);
        }

        public void DeleteContactUsPage(int pageId)
        {
            this.contactUsPageRepository.DeleteContactUsPage(pageId);
        }

        public List<Contactuspage> GetAllContactUsPages()
        {
            return this.contactUsPageRepository.GetAllContactUsPages();
        }

        public Contactuspage GetContactUsPageById(int pageId)
        {
            return this.contactUsPageRepository.GetContactUsPageById(pageId);
        }

        public void UpdateContactUsPage(Contactuspage contactUsPage)
        {
            this.contactUsPageRepository.UpdateContactUsPage(contactUsPage);
        }
    }


}
