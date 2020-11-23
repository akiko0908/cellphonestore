using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CellphoneStore.Models
{
    public class Categories
    {
        [Key]
        [Display(Name = "Mã loại SP")]
        public int categories_ID { get; set; }

        [Display(Name = "Tên loại sản phẩm")]
        public string categories_Name { get; set; }

        public virtual ICollection<Product> GetProducts { get; set; }
    }
}
