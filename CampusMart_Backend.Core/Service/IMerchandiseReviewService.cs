using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Service
{
    public interface IMerchandiseReviewService
    {
     List<MerchandiseReview> GetAllMerchandiseReviews();
        MerchandiseReview GetMerchandiseReviewById(int merchandiseReviewId);
        void CreateMerchandiseReview(MerchandiseReview merchandiseReview);
        void UpdateMerchandiseReview(MerchandiseReview merchandiseReview);
        void DeleteMerchandiseReview(int merchandiseReviewId);
    }
}
