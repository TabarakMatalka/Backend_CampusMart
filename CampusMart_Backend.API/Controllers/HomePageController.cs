using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomePageController : ControllerBase
    {
        private readonly IHomePageService homePageService;

        public HomePageController(IHomePageService homePageService)
        {
            this.homePageService = homePageService;
        }

        [HttpGet]
        [Route("GetAllHomePages")]
        public List<Homepage> GetAllHomePages()
        {
            return homePageService.GetAllHomePages();
        }

        [HttpGet]
        [Route("GetHomePageById/{id}")]
        public Homepage GetHomePageById(int id)
        {
            return homePageService.GetHomePageById(id);
        }

        [HttpPost]
        [Route("CreateHomePage")]
        public void CreateHomePage(Homepage homePage)
        {
            homePageService.CreateHomePage(homePage);
        }

        [HttpPut]
        [Route("UpdateHomePage")]
        public void UpdateHomePage(Homepage homePage)
        {
            homePageService.UpdateHomePage(homePage);
        }

        [HttpDelete]
        [Route("DeleteHomePage/{id}")]
        public void DeleteHomePage(int id)
        {
            homePageService.DeleteHomePage(id);
        }
    }
}
