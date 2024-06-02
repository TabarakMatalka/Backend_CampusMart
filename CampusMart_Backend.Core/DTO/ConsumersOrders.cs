using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.DTO
{
    public class ConsumersOrders
    {
        public decimal Consumerid { get; set; }
        public decimal? Isprovider { get; set; }
        public string? LocationLatitude { get; set; }
        public string? LocationLongitude { get; set; }
        public string? Fullname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Status { get; set; }

        public decimal Orderid { get; set; }
        public string? Ordernumber { get; set; }
        public string? Orderstatus { get; set; }
        public decimal? Totalamount { get; set; }
        public string? Location { get; set; }
        public string? LOCATION_LATITUDE { get; set; }
        public string? LOCATION_LONGITUDE { get; set; }
        public string? Deliveryaddress { get; set; }
        public DateTime? Orderdate { get; set; }
        public decimal? Providerid { get; set; }
        public decimal? Paymentid { get; set; }
    }

}
