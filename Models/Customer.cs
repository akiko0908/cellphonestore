using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CellphoneStore.Models
{
    public class Customer
    {
        [Key]
        [Display(Name = "Mã khách hàng")]
        public int customer_ID { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên khách hàng!!!")]
        [Display(Name = "Tên khách hàng")]
        public string customer_Name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại khách hàng!!!")]
        [Display(Name = "Số điện thoại")]
        [Range(10, 11, ErrorMessage = "Số điện thoại phải có 10 hoặc 11 chữ số!!!")]
        public string customer_PhoneNumber { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập email!!!")]
        [Display(Name = "Email")]
        public string customer_Email { get; set; }

        [Required(ErrorMessage = "Nhập địa chỉ giao hàng tại đây!!!")]
        [Display(Name = "Địa chỉ giao hàng 1")]
        public string customer_AddressShip1 { get; set; }

        [Display(Name = "Địa chỉ giao hàng 2")]
        public string customer_AddressShip2 { get; set; }
    }
}
