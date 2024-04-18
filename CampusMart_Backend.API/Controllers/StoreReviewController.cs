using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreReviewController : ControllerBase
    {
       private readonly IStoreReviewService storeReviewService;

        public StoreReviewController(IStoreReviewService storeReviewService)
        {
            this.storeReviewService = storeReviewService;
        }

        [HttpGet]
        [Route("GetAllStoreReviews")]
        public List<StoreReview> GetAllStoreReviews()
        {
            return storeReviewService.GetAllStoreReviews();
        }

        [HttpGet]
        [Route("GetStoreReviewById/{storeReviewId}")]
        public StoreReview GetStoreReviewById(int storeReviewId)
        {
            return storeReviewService.GetStoreReviewById(storeReviewId);
        }

        [HttpPost]
        [Route("CreateStoreReview")]
        public void CreateStoreReview(StoreReview storeReview)
        {
            storeReviewService.CreateStoreReview(storeReview);
        }

        [HttpPut]
        [Route("UpdateStoreReview")]
        public void UpdateStoreReview(StoreReview storeReview)
        {
            storeReviewService.UpdateStoreReview(storeReview);
        }

        [HttpDelete]
        [Route("DeleteStoreReview/{storeReviewId}")]
        public void DeleteStoreReview(int storeReviewId)
        {
            storeReviewService.DeleteStoreReview(storeReviewId);
        }
    }
}
