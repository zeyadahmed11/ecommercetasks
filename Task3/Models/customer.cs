using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task3.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string address { get; set; }
        public int ID { get; set; }
        public  int  O_ID { get; set; }
        public Order Order_odr { get; set; }
}

    

   
}
