using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pet_shop_online.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        [Required]
        public String RoleTitle { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}