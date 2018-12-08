using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task3.Models
{
    public class Customer
    {
        [Required] [DisplayName("your Name")]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        public string address { get; set; }
        [Required]
        public int ID { get; set; }
        public  int  O_ID { get; set; }
        public Order Order_odr { get; set; }
}

    

   
}
