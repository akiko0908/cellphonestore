using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CellphoneStore.Models
{
    public class Comment
    {
        [Key]
        [Display(Name = "Mã comment")]
        public int comment_ID { get; set; }

        [Display(Name = "Nội dung")]
        public string comment_Content { get; set; }

        [Display(Name = "Ngày comment")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime comment_CreateOnDay { get; set; }

        [ForeignKey("Product")]
        public int? product_ID { get; set; }
        public virtual Product Product { get; set; }

        [ForeignKey("Customer")]
        public int? customer_ID { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
