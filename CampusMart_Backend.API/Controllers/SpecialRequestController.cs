using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialRequestController : ControllerBase
    {
       private readonly ISpecialRequestService specialRequestService;

        public SpecialRequestController(ISpecialRequestService specialRequestService)
        {
            this.specialRequestService = specialRequestService;
        }

        [HttpGet]
        [Route("GetAllRequests")]
        public List<Specialrequest> GetAllRequests()
        {
            return specialRequestService.GetAllRequests();
        }

        [HttpGet]
        [Route("GetRequestById/{requestId}")]
        public Specialrequest GetRequestById(int requestId)
        {
            return specialRequestService.GetRequestById(requestId);
        }

        [HttpPost]
        [Route("CreateRequest")]
        public void CreateRequest(Specialrequest request)
        {
            specialRequestService.CreateRequest(request);
        }

        [HttpPut]
        [Route("UpdateRequest")]
        public void UpdateRequest(Specialrequest request)
        {
            specialRequestService.UpdateRequest(request);
        }

        [HttpDelete]
        [Route("DeleteRequest/{requestId}")]
        public void DeleteRequest(int requestId)
        {
            specialRequestService.DeleteRequest(requestId);
        }
    }
}
