using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pet_shop_online.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        public String CategoryName { get; set; }

        public virtual ICollection<Product>Products { get; set; }
    }
}