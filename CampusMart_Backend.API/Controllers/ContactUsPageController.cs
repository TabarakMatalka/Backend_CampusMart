using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsPageController : ControllerBase
    {
       private readonly IContactUsPageService contactUsPageService;

        public ContactUsPageController(IContactUsPageService contactUsPageService)
        {
            this.contactUsPageService = contactUsPageService;
        }

        [HttpGet]
        [Route("GetAllContactUsPages")]
        public List<Contactuspage> GetAllContactUsPages()
        {
            return contactUsPageService.GetAllContactUsPages();
        }

        [HttpGet]
        [Route("GetContactUsPageById/{id}")]
        public Contactuspage GetContactUsPageById(int id)
        {
            return contactUsPageService.GetContactUsPageById(id);
        }

        [HttpPost]
        [Route("CreateContactUsPage")]
        public void CreateContactUsPage(Contactuspage contactUsPage)
        {
            contactUsPageService.CreateContactUsPage(contactUsPage);
        }

        [HttpPut]
        [Route("UpdateContactUsPage")]
        public void UpdateContactUsPage(Contactuspage contactUsPage)
        {
            contactUsPageService.UpdateContactUsPage(contactUsPage);
        }

        [HttpDelete]
        [Route("DeleteContactUsPage/{id}")]
        public void DeleteContactUsPage(int id)
        {
            contactUsPageService.DeleteContactUsPage(id);
        }
    }
}
