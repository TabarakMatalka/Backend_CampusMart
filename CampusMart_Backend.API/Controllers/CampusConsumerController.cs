using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
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
    }
}
