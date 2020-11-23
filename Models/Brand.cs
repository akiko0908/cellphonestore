using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CellphoneStore.Models
{
    public class Brand
    {
        [Key]
        [Display(Name = "Mã Hãng sản xuất")]
        public int brand_ID { get; set; }

        [Display(Name = "Tên hãng sản xuất")]
        public string brand_Name { get; set; }

        public virtual ICollection<Product> GetProducts { get; set; }
    }
}
