using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CellphoneStore.Models
{
    public class Supplier
    {
        [Key]
        [Display(Name = "Mã nhà cung cấp")]
        public int supplier_ID { get; set; }

        [Display(Name = "Tên nhà cung cấp")]
        public string supplier_Name { get; set; }

        public virtual ICollection<Product> GetProducts { get; set; }
    }
}
