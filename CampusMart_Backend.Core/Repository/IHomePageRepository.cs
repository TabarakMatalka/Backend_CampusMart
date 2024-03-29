using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Repository
{
    public interface IHomePageRepository
    {
        List<Homepage> GetAllHomePages();
        Homepage GetHomePageById(int homePageId);
        void CreateHomePage(Homepage homePage);
        void UpdateHomePage(Homepage homePage);
        void DeleteHomePage(int homePageId);
    }
}
