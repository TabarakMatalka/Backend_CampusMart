using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
   [Route("api/[controller]")]
    [ApiController]
    public class AboutUsPageController : ControllerBase
    {
        private readonly IAboutUsPageService aboutUsPageService;

        public AboutUsPageController(IAboutUsPageService aboutUsPageService)
        {
            this.aboutUsPageService = aboutUsPageService;
        }

        [HttpGet]
        [Route("GetAllAboutUsPages")]
        public List<Aboutuspage> GetAllAboutUsPages()
        {
            return aboutUsPageService.GetAllAboutUsPages();
        }

        [HttpGet]
        [Route("GetAboutUsPageById/{id}")]
        public Aboutuspage GetAboutUsPageById(int id)
        {
            return aboutUsPageService.GetAboutUsPageById(id);
        }

        [HttpPost]
        [Route("CreateAboutUsPage")]
        public void CreateAboutUsPage(Aboutuspage aboutUsPage)
        {
            aboutUsPageService.CreateAboutUsPage(aboutUsPage);
        }

        [HttpPut]
        [Route("UpdateAboutUsPage")]
        public void UpdateAboutUsPage(Aboutuspage aboutUsPage)
        {
            aboutUsPageService.UpdateAboutUsPage(aboutUsPage);
        }

        [HttpDelete]
        [Route("DeleteAboutUsPage/{id}")]
        public void DeleteAboutUsPage(int id)
        {
            aboutUsPageService.DeleteAboutUsPage(id);
        }
    }
}
