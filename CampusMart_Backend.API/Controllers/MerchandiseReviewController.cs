using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MerchandiseReviewController : ControllerBase
    {
        private readonly IMerchandiseReviewService merchandiseReviewService;

        public MerchandiseReviewController(IMerchandiseReviewService merchandiseReviewService)
        {
            this.merchandiseReviewService = merchandiseReviewService;
        }

        [HttpGet]
        [Route("GetAllMerchandiseReviews")]
        public List<MerchandiseReview> GetAllMerchandiseReviews()
        {
            return merchandiseReviewService.GetAllMerchandiseReviews();
        }

        [HttpGet]
        [Route("GetMerchandiseReviewById/{id}")]
        public MerchandiseReview GetMerchandiseReviewById(int id)
        {
            return merchandiseReviewService.GetMerchandiseReviewById(id);
        }

        [HttpPost]
        [Route("CreateMerchandiseReview")]
        public void CreateMerchandiseReview(MerchandiseReview merchandiseReview)
        {
            merchandiseReviewService.CreateMerchandiseReview(merchandiseReview);
        }

        [HttpPut]
        [Route("UpdateMerchandiseReview")]
        public void UpdateMerchandiseReview(MerchandiseReview merchandiseReview)
        {
            merchandiseReviewService.UpdateMerchandiseReview(merchandiseReview);
        }

        [HttpDelete]
        [Route("DeleteMerchandiseReview/{id}")]
        public void DeleteMerchandiseReview(int id)
        {
            merchandiseReviewService.DeleteMerchandiseReview(id);
        }
    }
}
