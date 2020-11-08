using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pet_shop_online.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public float Price { get; set; }
        public DateTime Date { get; set; }
        public int CategoryID { get; set; }
        public int AnimalID { get; set; }

        public virtual ICollection <Comment>Comments { get; set; }
        public virtual Category Category { get; set; }
        public virtual Animal Animal { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
        public IEnumerable<SelectListItem> Animals { get; set; }


    }
}