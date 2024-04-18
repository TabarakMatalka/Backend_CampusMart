using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Cart
    {
        public decimal Cartid { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Total { get; set; }
        public decimal? Consumerid { get; set; }
        public decimal? Productid { get; set; }
        public decimal? Orderid { get; set; }
        public decimal? Storeid { get; set; }

        public virtual Campusconsumer? Consumer { get; set; }
        public virtual Order? Order { get; set; }
        public virtual Merchandise? Product { get; set; }
        public virtual Store? Store { get; set; }
    }
}
