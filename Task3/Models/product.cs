using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task3.Models
{
    public class Product
    {
        public int P_ID { get; set; }
        public string P_Name { get; set; }
        public int Quantity { get; set; }
        public String Model { get; set; }
        public List<Order> listo { get; set; }

    }
}
