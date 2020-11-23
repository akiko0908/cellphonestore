using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CellphoneStore.Models
{
    public class HeDieuHanh
    {
        [Key]
        [Display(Name = "Mã hệ điều hành")]
        public int hdh_ID { get; set; }

        [Display(Name = "Tên hệ điều hành")]
        public string hdh_Name { get; set; }

        public virtual ICollection<Product> GetProducts { get; set; }
    }
}
