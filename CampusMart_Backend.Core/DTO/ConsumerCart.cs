using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.DTO
{
    public class ConsumerCart
    {
        public decimal CartID { get; set; }
        public decimal ConsumerID { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal ProductID { get; set; }
        public decimal Quantity { get; set; }
        public decimal Total { get; set; }
       
    }
}
