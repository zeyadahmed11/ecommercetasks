using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task3.Models
{
    public class Order
    {
        [Required]
        public int O_ID { get; set; }
        [StringLength(50,ErrorMessage="limited")]
        public string P_Name { get; set; }
        public int Quantity { get; set; }
        public string CAddress { get; set; }
        public List<Customer> listc { get; set; }
        public List<Product> listp { get; set; }

    }
}
