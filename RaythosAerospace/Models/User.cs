using System;
using System.ComponentModel.DataAnnotations;
using RaythosAerospace.Data;
using RaythosAerospace.Data.Base;

namespace RaythosAerospace.Models
{
    public class User: IEntityBase
    {
        public User()
        {}
        [Key]
        public int Id { get; set; }

        [Display(Name = "Prifile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }

        public string Password { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
        public UserRoles Role { get; set; }
    }
}

