using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task3.Models
{
    public class Product
    {

        [Required]
        [Key]
        [DisplayName("product ID ")]
        public int P_ID { get; set; }
        [Required]
        [DisplayName("PRODUCT NAME")]
       
        public string P_Name { get; set; }
        public int Quantity { get; set; }
        public string Model { get; set; }
        public List<C_O> listo { get; set; }

    }
}
