using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pet_shop_online.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int ProductID { get; set; }
        public int UserID { get; set; }

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }


    }
}