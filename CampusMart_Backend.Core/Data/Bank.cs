using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Bank
    {
        public decimal Bankid { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Cardholder { get; set; }
        public string? Cardnumber { get; set; }
        public decimal? Balance { get; set; }
        public string? Cvv { get; set; }
        public decimal? Paymentid { get; set; }
        public decimal? Consumerid { get; set; }

        public virtual Campusconsumer? Consumer { get; set; }
        public virtual Payment? Payment { get; set; }
    }
}
