using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pet_shop_online.Models
{
    public class Cart
    {
        [Key]
        [ForeignKey("User")]
        public int CartID { get; set; }
        
        

        public virtual ICollection<CartLine> CartLines { get; set; }
        public virtual User User { get; set; }
    }
}