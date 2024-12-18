using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeMeoo.Entities
{
    public class TableDetail
    {
        [Key]
        public string ID { get; set; }
        public int SL { get; set; }
        public string Name { get; set; }
        public int Total { get; set; }
    }
}
