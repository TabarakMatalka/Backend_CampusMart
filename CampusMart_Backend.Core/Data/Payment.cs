using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Payment
    {
        public Payment()
        {
            Banks = new HashSet<Bank>();
            Orders = new HashSet<Order>();
        }

        public decimal Paymentid { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string? PaymentMethod { get; set; }

        public virtual ICollection<Bank> Banks { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
