using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CellphoneStore.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "Mã sản phẩm")]
        public int product_ID { get; set; }

        [Required(ErrorMessage = "Sản phẩm phải được nhập tên!!!")]
        [Display(Name = "Tên sản phẩm")]
        public string product_Name { get; set; }

        [Required(ErrorMessage = "")]
        [Display(Name = "Giá SP")]
        [Range(10000, 100000000, ErrorMessage = "Giá sản phẩm từ 10,000 đến 100,000,000vnđ!!!")]
        [DataType(DataType.Currency)]
        public decimal product_Price { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số lượng sản phẩm!!!")]
        [Display(Name = "Số lượng")]
        [Range(1, 1000, ErrorMessage = "Số lượng sản phẩm từ 1 đến 1,000 SP!!!")]
        public int product_Quantity { get; set; }

        [Display(Name = "Hình ảnh")]
        public string product_Image { get; set; }

        [Display(Name = "Mô tả sản phẩm")]
        public string product_Description { get; set; }

        [ForeignKey("Brand")]
        public int? brand_ID { get; set; }
        public virtual Brand Brand { get; set; }

        [ForeignKey("HeDieuHanh")]
        public int? hdh_ID { get; set; }
        public virtual HeDieuHanh HeDieuHanh { get; set; }

        [ForeignKey("Supplier")]
        public int? supplier_ID { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
