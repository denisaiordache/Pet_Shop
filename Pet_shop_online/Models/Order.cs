using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pet_shop_online.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [Required]
        public int UserID { get; set; }
        public DateTime Date { get; set; }
        
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public virtual User User { get; set; }

    }
}