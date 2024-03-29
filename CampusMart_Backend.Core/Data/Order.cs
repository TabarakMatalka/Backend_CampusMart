using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Order
    {
        public Order()
        {
            Carts = new HashSet<Cart>();
        }

        public decimal Orderid { get; set; }
        public string? Ordernumber { get; set; }
        public string? Orderstatus { get; set; }
        public decimal? Totalamount { get; set; }
        public string? Location { get; set; }
        public string? Deliveryaddress { get; set; }
        public DateTime? Orderdate { get; set; }
        public decimal Consumerid { get; set; }
        public decimal Providerid { get; set; }
        public decimal Paymentid { get; set; }

        public virtual Campusconsumer Consumer { get; set; } = null!;
        public virtual Payment Payment { get; set; } = null!;
        public virtual Campusserviceprovider Provider { get; set; } = null!;
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
