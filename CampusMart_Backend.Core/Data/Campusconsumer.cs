using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Campusconsumer
    {
        public Campusconsumer()
        {
            Carts = new HashSet<Cart>();
            Logins = new HashSet<Login>();
            Orders = new HashSet<Order>();
            Specialrequests = new HashSet<Specialrequest>();
            Testimonials = new HashSet<Testimonial>();
        }

        public decimal Consumerid { get; set; }
        public string? Phone { get; set; }
        public bool? Isprovider { get; set; }
        public decimal Userid { get; set; }

        public virtual Generaluser User { get; set; } = null!;
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Specialrequest> Specialrequests { get; set; }
        public virtual ICollection<Testimonial> Testimonials { get; set; }
    }
}
