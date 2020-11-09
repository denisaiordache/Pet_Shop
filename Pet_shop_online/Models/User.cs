using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pet_shop_online.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public int RoleID { get; set; }
        

        public virtual Role Role { get; set; }
        public virtual Cart Cart { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}