using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CellphoneStore.Models
{
    public class DeliveryCost
    {
        [Key]
        [Display(Name = "Mã dịch vụ")]
        public int deliverycost_ID { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên khu vực!!!")]
        [Display(Name = "Khu vực vẫn chuyển")]
        public string deliverycost_AreaName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập giá vận chuyển cho khu vực!!!")]
        [Display(Name = "Giá vận chuyển")]
        [Range(15000, 1000000, ErrorMessage = "Giá vận chuyển từ 15,000 đến 1,000,000vnđ!!!")]
        [DataType(DataType.Currency)]
        public decimal deliverycost_Cost { get; set; }
    }
}
