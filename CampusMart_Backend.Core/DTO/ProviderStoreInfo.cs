using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.DTO
{
   public  class ProviderStoreInfo
    {
        public decimal Providerid { get; set; }
        public decimal Consumerid { get; set; }
        public decimal? Isprovider { get; set; }

        public decimal Storeid { get; set; }
        public string? Storename { get; set; }
        public decimal? Isopen { get; set; }
        public decimal? Rate { get; set; }
        public string? Approvalstatus { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
    }
}
