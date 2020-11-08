using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pet_shop_online.Models
{
    public class Animal
    {
        [Key]
        public int AnimalID { get; set; }
        [Required]
        public string Species { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}