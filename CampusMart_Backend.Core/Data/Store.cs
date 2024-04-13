using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Store
    {
        public Store()
        {
            Carts = new HashSet<Cart>();
            Merchandises = new HashSet<Merchandise>();
            StoreReviews = new HashSet<StoreReview>();
        }

        public decimal Storeid { get; set; }
        public string? Storename { get; set; }
        public decimal? Isopen { get; set; }
        public decimal? Rate { get; set; }
        public string? Approvalstatus { get; set; }
        public string? Image { get; set; }
        public decimal? Providerid { get; set; }

        public virtual Campusserviceprovider? Provider { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Merchandise> Merchandises { get; set; }
        public virtual ICollection<StoreReview> StoreReviews { get; set; }
    }
}
