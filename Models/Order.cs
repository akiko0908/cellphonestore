using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CellphoneStore.Models
{
    public class Order
    {
        public int order_ID { get; set; }

        public DateTime order_CreateOnDay { get; set; }

        public decimal order_Total { get; set; }

        public DateTime order_PaymentDate { get; set; }

        public string order_PaymentMethod { get; set; }

        [ForeignKey("Customer")]
        public int? customer_ID { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("DeliveryCost")]
        public int? deliverycost_ID { get; set; }
        public virtual DeliveryCost DeliveryCost { get; set; }

        [ForeignKey("Promotion")]
        public int? promotion_ID { get; set; }
        public virtual Promotion Promotion { get; set; }
    }
}
