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
    public class AboutUsPageService : IAboutUsPageService
    {
        private readonly IAboutUsPageRepository aboutUsPageRepository;

        public AboutUsPageService(IAboutUsPageRepository aboutUsPageRepository)
        {
            this.aboutUsPageRepository = aboutUsPageRepository;
        }

        public void CreateAboutUsPage(Aboutuspage aboutUsPage)
        {
            this.aboutUsPageRepository.CreateAboutUsPage(aboutUsPage);
        }

        public void DeleteAboutUsPage(int pageId)
        {
            this.aboutUsPageRepository.DeleteAboutUsPage(pageId);
        }

        public List<Aboutuspage> GetAllAboutUsPages()
        {
            return this.aboutUsPageRepository.GetAllAboutUsPages();
        }

        public Aboutuspage GetAboutUsPageById(int pageId)
        {
            return this.aboutUsPageRepository.GetAboutUsPageById(pageId);
        }

        public void UpdateAboutUsPage(Aboutuspage aboutUsPage)
        {
            this.aboutUsPageRepository.UpdateAboutUsPage(aboutUsPage);
        }
    }
}
