using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Login
    {
        public decimal Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public decimal? Consumerid { get; set; }
        public decimal? Roleid { get; set; }

        public virtual Campusconsumer? Consumer { get; set; }
        public virtual Role? Role { get; set; }
    }
}
