using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class MerchandiseReview
    {
        public decimal MerchandiseReviewId { get; set; }
        public decimal Consumerid { get; set; }
        public decimal Productid { get; set; }
        public decimal Orderid { get; set; }
        public decimal? Rating { get; set; }
        public string? ReviewText { get; set; }
        public DateTime? ReviewDate { get; set; }

        public virtual Campusconsumer Consumer { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
        public virtual Merchandise Product { get; set; } = null!;
    }
}
