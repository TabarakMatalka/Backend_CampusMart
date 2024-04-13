using System;
using System.Collections.Generic;

namespace CampusMart_Backend.Core.Data
{
    public partial class Specialrequest
    {
        public decimal Requestid { get; set; }
        public string? Requesttitle { get; set; }
        public string? Requestdetails { get; set; }
        public string? Requeststatus { get; set; }
        public decimal? Consumerid { get; set; }
        public decimal? Providerid { get; set; }

        public virtual Campusconsumer? Consumer { get; set; }
        public virtual Campusserviceprovider? Provider { get; set; }
    }
}
