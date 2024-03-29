using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Repository
{
    public interface IStoreReviewRepository
    {
        List<StoreReview> GetAllStoreReviews();
        StoreReview GetStoreReviewById(int storeReviewId);
        void CreateStoreReview(StoreReview storeReview);
        void UpdateStoreReview(StoreReview storeReview);
        void DeleteStoreReview(int storeReviewId);
    }
}
