using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Repository
{
    public interface IContactUsPageRepository
    {
        List<Contactuspage> GetAllContactUsPages();
        Contactuspage GetContactUsPageById(int pageId);
        void CreateContactUsPage(Contactuspage contactUsPage);
        void UpdateContactUsPage(Contactuspage contactUsPage);
        void DeleteContactUsPage(int pageId);
    }
}
