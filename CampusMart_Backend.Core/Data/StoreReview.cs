using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class StoreReview
    {
        public decimal StoreReviewId { get; set; }
        public decimal Consumerid { get; set; }
        public decimal Storeid { get; set; }
        public decimal Orderid { get; set; }
        public decimal? Rating { get; set; }
        public string? ReviewText { get; set; }
        public DateTime? ReviewDate { get; set; }

        public virtual Campusconsumer Consumer { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
        public virtual Store Store { get; set; } = null!;
    }
}
