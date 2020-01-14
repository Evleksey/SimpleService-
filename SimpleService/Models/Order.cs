using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleService.Models
{
    public class Order
    {
        public uint OrderID { get; set; }
        public List<Product> Products { get; set; }
        public DateTime date { get; set; }
        public uint CustomerID { get; set; }
    }
}
