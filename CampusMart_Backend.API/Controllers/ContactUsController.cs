using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
       private readonly IContactUsService contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            this.contactUsService = contactUsService;
        }

        [HttpGet]
        [Route("GetAllContacts")]
        public List<Contactu> GetAllContacts()
        {
            return contactUsService.GetAllContacts();
        }

        [HttpGet]
        [Route("GetContactById/{id}")]
        public Contactu GetContactById(int id)
        {
            return contactUsService.GetContactById(id);
        }

        [HttpPost]
        [Route("CreateContact")]
        public void CreateContact(Contactu contact)
        {
            contactUsService.CreateContact(contact);
        }

        [HttpPut]
        [Route("UpdateContact")]
        public void UpdateContact(Contactu contact)
        {
            contactUsService.UpdateContact(contact);
        }

        [HttpDelete]
        [Route("DeleteContact/{id}")]
        public void DeleteContact(int id)
        {
            contactUsService.DeleteContact(id);
        }
    }
}
