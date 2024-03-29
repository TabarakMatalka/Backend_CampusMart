using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Generaluser
    {
        public Generaluser()
        {
            Campusconsumers = new HashSet<Campusconsumer>();
            Campusserviceproviders = new HashSet<Campusserviceprovider>();
        }

        public decimal Userid { get; set; }
        public string? Fullname { get; set; }
        public string Email { get; set; } = null!;
        public string? Imagepath { get; set; }
        public string? Phone { get; set; }
        public string? Status { get; set; }
        public string Password { get; set; } = null!;
        public decimal Roleid { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<Campusconsumer> Campusconsumers { get; set; }
        public virtual ICollection<Campusserviceprovider> Campusserviceproviders { get; set; }
    }
}
