using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CellphoneStore.Models
{
    public class OrderDetail
    {
        [Key, Column(Order = 1)]
        [Display(Name = "Mã đơn hàng")]
        public int order_ID { get; set; }
        public virtual Order Order { get; set; }

        [Key, Column(Order = 2)]
        [Display(Name = "Mã sản phẩm")]
        public int product_ID { get; set; }
        public virtual Product Product { get; set; }

        [Display(Name = "Số lượng")]
        [Range(1, 20, ErrorMessage = "Số lượng mua từ 1 đến 20 sản phẩm!!!")]
        public int orderdetail_Quantity { get; set; }
    }
}
