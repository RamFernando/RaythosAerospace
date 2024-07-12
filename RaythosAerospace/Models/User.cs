using System;
using System.ComponentModel.DataAnnotations;
using RaythosAerospace.Data;

namespace RaythosAerospace.Models
{
    public class User
    {
        public User()
        {}
        [Key]
        public int UserId { get; set; }

        public string ProfilePictureURL { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public UserRoles Role { get; set; }
    }
}

