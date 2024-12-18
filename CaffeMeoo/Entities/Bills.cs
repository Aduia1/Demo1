using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeMeoo.Entities
{
    public class Bills
    {
        [Key]

        public string tableId { get; set; }
        public string billId { get; set; }
        public int Total { get; set; }
        public List<TableDetail> Details { get; set; }
        public string PaymentTime { get; set; } // Thời gian thanh toán

    }
}
