using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GIVE_AID.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Avatar { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; } = true;
        public virtual UserDetail UserDetail { get; set; }
        public virtual ICollection<UsersRolesMapping> UsersRolesMappings { get; internal set; }
        public virtual ICollection<Donation> Donations { get; set; }
        public virtual ICollection<NGO> NGOs { get; set; }
    }
}