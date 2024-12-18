using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeMeoo.Entities
{
     public class CartItem
    {
        [Key]
        public int Id { get; set; }
        public string DrinkName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int TotalPrice { get; set; }
    }
}
