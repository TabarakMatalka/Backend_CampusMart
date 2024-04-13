using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Campusconsumer
    {
        public Campusconsumer()
        {
            Banks = new HashSet<Bank>();
            Carts = new HashSet<Cart>();
            Logins = new HashSet<Login>();
            MerchandiseReviews = new HashSet<MerchandiseReview>();
            Orders = new HashSet<Order>();
            Specialrequests = new HashSet<Specialrequest>();
            StoreReviews = new HashSet<StoreReview>();
            Testimonials = new HashSet<Testimonial>();
        }

        public decimal Consumerid { get; set; }
        public string? Phone { get; set; }
        public decimal? Isprovider { get; set; }
        public string? LocationLatitude { get; set; }
        public string? LocationLongitude { get; set; }
        public decimal? Userid { get; set; }

        public virtual Generaluser? User { get; set; }
        public virtual ICollection<Bank> Banks { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
        public virtual ICollection<MerchandiseReview> MerchandiseReviews { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Specialrequest> Specialrequests { get; set; }
        public virtual ICollection<StoreReview> StoreReviews { get; set; }
        public virtual ICollection<Testimonial> Testimonials { get; set; }
    }
}
