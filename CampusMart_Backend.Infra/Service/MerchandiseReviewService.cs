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
    public class MerchandiseReviewService : IMerchandiseReviewService
    {
      private readonly IMerchandiseReviewRepository merchandiseReviewRepository;

        public MerchandiseReviewService(IMerchandiseReviewRepository merchandiseReviewRepository)
        {
            this.merchandiseReviewRepository = merchandiseReviewRepository;
        }

        public void CreateMerchandiseReview(MerchandiseReview merchandiseReview)
        {
            this.merchandiseReviewRepository.CreateMerchandiseReview(merchandiseReview);
        }

        public void DeleteMerchandiseReview(int merchandiseReviewId)
        {
            this.merchandiseReviewRepository.DeleteMerchandiseReview(merchandiseReviewId);
        }

        public List<MerchandiseReview> GetAllMerchandiseReviews()
        {
            return this.merchandiseReviewRepository.GetAllMerchandiseReviews();
        }

        public MerchandiseReview GetMerchandiseReviewById(int merchandiseReviewId)
        {
            return this.merchandiseReviewRepository.GetMerchandiseReviewById(merchandiseReviewId);
        }

        public void UpdateMerchandiseReview(MerchandiseReview merchandiseReview)
        {
            this.merchandiseReviewRepository.UpdateMerchandiseReview(merchandiseReview);
        }
    }
}
