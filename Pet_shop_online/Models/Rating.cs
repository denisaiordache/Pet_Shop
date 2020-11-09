using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pet_shop_online.Models
{
    public class Rating
    {
        [Key]
        public int RatingID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int ProductID { get; set; }
        [Required]
        public int Value { get; set; }

        public virtual User User { get; set; }
        public virtual Product Ptoduct { get; set; }

    }
}