using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using CampusMart_Backend.Infra.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampusConsumerController : ControllerBase
    {
       private readonly ICampusConsumerService campusConsumerService;

        public CampusConsumerController(ICampusConsumerService campusConsumerService)
        {
            this.campusConsumerService = campusConsumerService;
        }

        [HttpGet]
        [Route("GetAllConsumers")]
        public List<Campusconsumer> GetAllConsumers()
        {
            return campusConsumerService.GetAllConsumers();
        }

        [HttpGet]
        [Route("GetConsumerById/{id}")]
        public Campusconsumer GetConsumerById(int id)
        {
            return campusConsumerService.GetConsumerById(id);
        }

        [HttpPost]
        [Route("CreateConsumer")]
        public void CreateConsumer(Campusconsumer consumer)
        {
            campusConsumerService.CreateConsumer(consumer);
        }

        [HttpPost]
        [Route("CreateCampusConsumerLogin")]
        public void CreateCampusConsumerLogin(Campusconsumer consumer)
        {
            campusConsumerService.CreateCampusConsumerLogin(consumer);
        }
            
        [HttpPut]
        [Route("UpdateConsumer")]
        public void UpdateConsumer(Campusconsumer consumer)
        {
            campusConsumerService.UpdateConsumer(consumer);
        }

        [HttpDelete]
        [Route("DeleteConsumer/{id}")]
        public void DeleteConsumer(int id)
        {
            campusConsumerService.DeleteConsumer(id);
        }

        [Route("uploadImage")]
        [HttpPost]
        public IActionResult UploadImage()
        {
            var file = Request.Form.Files[0];

            if (file != null && (file.ContentType == "image/jpeg" || file.ContentType == "image/jpg" || file.ContentType == "image/png"))
            {
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var fullPath = Path.Combine("C:\\Users\\user\\Desktop\\GP\\github\\frontend\\CampusMart\\src\\assets\\img\\campus_consumer", fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Campusconsumer item = new Campusconsumer();
                item.Imagepath = fileName;
                return Ok(item);
            }
            else
            {
                return BadRequest("Invalid file format. Please upload an image file.");
            }
        }

       
        [Route("GetConsumerByEmail")]
        [HttpGet]
        public Campusconsumer GetConsumerByEmail(string email)
        {
            return this.campusConsumerService.GetConsumerByEmail(email);
        }
    }
}

  
