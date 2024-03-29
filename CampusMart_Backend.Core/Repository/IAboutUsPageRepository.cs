using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Repository
{
    public interface IAboutUsPageRepository
    {
        List<Aboutuspage> GetAllAboutUsPages();
        Aboutuspage GetAboutUsPageById(int pageId);
        void CreateAboutUsPage(Aboutuspage aboutUsPage);
        void UpdateAboutUsPage(Aboutuspage aboutUsPage);
        void DeleteAboutUsPage(int pageId);
    }
}
