using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MerchandiseController : ControllerBase
    {
        private readonly IMerchandiseService merchandiseService;

        public MerchandiseController(IMerchandiseService merchandiseService)
        {
            this.merchandiseService = merchandiseService;
        }

        [HttpGet]
        [Route("GetAllMerchandise")]
        public List<Merchandise> GetAllMerchandise()
        {
            return merchandiseService.GetAllMerchandise();
        }

        [HttpGet]
        [Route("GetMerchandiseById/{id}")]
        public Merchandise GetMerchandiseById(int id)
        {
            return merchandiseService.GetMerchandiseById(id);
        }

        [HttpPost]
        [Route("CreateMerchandise")]
        public void CreateMerchandise(Merchandise merchandise)
        {
            merchandiseService.CreateMerchandise(merchandise);
        }

        [HttpPut]
        [Route("UpdateMerchandise")]
        public void UpdateMerchandise(Merchandise merchandise)
        {
            merchandiseService.UpdateMerchandise(merchandise);
        }

        [HttpDelete]
        [Route("DeleteMerchandise/{id}")]
        public void DeleteMerchandise(int id)
        {
            merchandiseService.DeleteMerchandise(id);
        }
    }
}
