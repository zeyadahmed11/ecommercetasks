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
        [Key][System.ComponentModel.DisplayName("order ID")]
        public int O_ID { get; set; }
        [StringLength(50,ErrorMessage="limited")]
        [Required]
        public string P_Name { get; set; }
        public int Quantity { get; set; }
        public string CAddress { get; set; }
        public List<Customer> List_customer { get; set; }
        public List<C_O> List_Product { get; set; }
    }
}

