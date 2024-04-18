using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Campusconsumer
    {
        public Campusconsumer()
        {
            Banks = new HashSet<Bank>();
            Campusserviceproviders = new HashSet<Campusserviceprovider>();
            Carts = new HashSet<Cart>();
            Logins = new HashSet<Login>();
            MerchandiseReviews = new HashSet<MerchandiseReview>();
            Orders = new HashSet<Order>();
            Specialrequests = new HashSet<Specialrequest>();
            StoreReviews = new HashSet<StoreReview>();
            Testimonials = new HashSet<Testimonial>();
        }

        public decimal Consumerid { get; set; }
        public decimal? Isprovider { get; set; }
        public string? LocationLatitude { get; set; }
        public string? LocationLongitude { get; set; }
        public string? Fullname { get; set; }
        public string? Email { get; set; }
        public string? Imagepath { get; set; }
        public string? Phone { get; set; }
        public string? Status { get; set; }
        public string? Password { get; set; }
        public decimal? Roleid { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Bank> Banks { get; set; }
        public virtual ICollection<Campusserviceprovider> Campusserviceproviders { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
        public virtual ICollection<MerchandiseReview> MerchandiseReviews { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Specialrequest> Specialrequests { get; set; }
        public virtual ICollection<StoreReview> StoreReviews { get; set; }
        public virtual ICollection<Testimonial> Testimonials { get; set; }
    }
}
