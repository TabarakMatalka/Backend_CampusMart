using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Role
    {
        public Role()
        {
            Generalusers = new HashSet<Generaluser>();
            Logins = new HashSet<Login>();
        }

        public decimal RoleId { get; set; }
        public string? RoleName { get; set; }

        public virtual ICollection<Generaluser> Generalusers { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
    }
}
