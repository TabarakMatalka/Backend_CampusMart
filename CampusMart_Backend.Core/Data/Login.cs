using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Login
    {
        public decimal Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public decimal Consumerid { get; set; }
        public decimal Roleid { get; set; }

        public virtual Campusconsumer Consumer { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;
    }
}
