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
    public class HomePageService : IHomePageService
    {
        private readonly IHomePageRepository homePageRepository;

        public HomePageService(IHomePageRepository homePageRepository)
        {
            this.homePageRepository = homePageRepository;
        }

        public void CreateHomePage(Homepage homePage)
        {
            this.homePageRepository.CreateHomePage(homePage);
        }

        public void DeleteHomePage(int homePageId)
        {
            this.homePageRepository.DeleteHomePage(homePageId);
        }

        public List<Homepage> GetAllHomePages()
        {
            return this.homePageRepository.GetAllHomePages();
        }

        public Homepage GetHomePageById(int homePageId)
        {
            return this.homePageRepository.GetHomePageById(homePageId);
        }

        public void UpdateHomePage(Homepage homePage)
        {
            this.homePageRepository.UpdateHomePage(homePage);
        }
    }

}
