using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CellphoneStore.Models
{
    public class Promotion
    {
        [Key]
        [Display(Name = "Mã khuyến mãi")]
        public int promotion_ID { get; set; }

        [Display(Name = "Tên khuyến mãi")]
        public string promotion_Name { get; set; }

        [Display(Name = "Phần trăm")]
        [Range(5, 75, ErrorMessage = "Chiết khẩu từ 5 đến 75% là tối đa!!!")]
        public int promotion_Percent { get; set; }
    }
}
