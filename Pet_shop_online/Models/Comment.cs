using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pet_shop_online.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int ProductID { get; set; }

        public virtual Product Product { get; set; }

        

    }
}