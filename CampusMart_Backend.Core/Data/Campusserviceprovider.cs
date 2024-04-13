using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Campusserviceprovider
    {
        public Campusserviceprovider()
        {
            Orders = new HashSet<Order>();
            Specialrequests = new HashSet<Specialrequest>();
            Stores = new HashSet<Store>();
        }

        public decimal Providerid { get; set; }
        public string? Phone { get; set; }
        public string? LocationLatitude { get; set; }
        public string? LocationLongitude { get; set; }
        public decimal? Userid { get; set; }

        public virtual Generaluser? User { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Specialrequest> Specialrequests { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}
