using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Role
    {
        public Role()
        {
            Campusconsumers = new HashSet<Campusconsumer>();
            Logins = new HashSet<Login>();
        }

        public decimal RoleId { get; set; }
        public string? RoleName { get; set; }

        public virtual ICollection<Campusconsumer> Campusconsumers { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
    }
}
