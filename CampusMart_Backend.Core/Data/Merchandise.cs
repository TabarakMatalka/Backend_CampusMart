using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Merchandise
    {
        public Merchandise()
        {
            Carts = new HashSet<Cart>();
        }

        public decimal Productid { get; set; }
        public string? Name { get; set; }
        public decimal? Rate { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public decimal? Price { get; set; }
        public decimal? Quantity { get; set; }
        public string? Image { get; set; }
        public decimal Storeid { get; set; }

        public virtual Store Store { get; set; } = null!;
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
