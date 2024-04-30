using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Repository;
using CampusMart_Backend.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Infra.Service
{

    public class StoreReviewService : IStoreReviewService
    {
       private readonly IStoreReviewRepository storeReviewRepository;

        public StoreReviewService(IStoreReviewRepository storeReviewRepository)
        {
            this.storeReviewRepository = storeReviewRepository;
        }

        public void CreateStoreReview(StoreReview storeReview)
        {
            this.storeReviewRepository.CreateStoreReview(storeReview);
        }

        public void DeleteStoreReview(int storeReviewId)
        {
            this.storeReviewRepository.DeleteStoreReview(storeReviewId);
        }

        public List<StoreReview> GetAllStoreReviews()
        {
            return this.storeReviewRepository.GetAllStoreReviews();
        }

        public StoreReview GetStoreReviewById(int storeReviewId)
        {
            return this.storeReviewRepository.GetStoreReviewById(storeReviewId);
        }

        public void UpdateStoreReview(StoreReview storeReview)
        {
            this.storeReviewRepository.UpdateStoreReview(storeReview);
        }
    }

}
