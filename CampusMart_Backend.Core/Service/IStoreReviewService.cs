using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Service
{
    public interface IStoreReviewService
    {
        List<StoreReview> GetAllStoreReviews();
        StoreReview GetStoreReviewById(int storeReviewId);
        void CreateStoreReview(StoreReview storeReview);
        void UpdateStoreReview(StoreReview storeReview);
        void DeleteStoreReview(int storeReviewId);
    }
}
