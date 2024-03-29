using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Testimonial
    {
        public decimal Testimonialid { get; set; }
        public string? Testimonialtext { get; set; }
        public string? Status { get; set; }
        public DateTime? Dateposted { get; set; }
        public decimal Consumerid { get; set; }

        public virtual Campusconsumer Consumer { get; set; } = null!;
    }
}
