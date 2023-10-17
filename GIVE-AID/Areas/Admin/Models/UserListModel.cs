using GIVE_AID.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace GIVE_AID.Areas.Admin.Models
{
    public class UserListModel
    {
        [Key]
        public int Id { get; set; }
        public string Avatar { get; set; }
        [Required(ErrorMessage = "Username is required")]
        [DisplayName("Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DisplayName("Password")]
        public string Password { get; set; }
        [DisplayName("Fullname")]
        [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        [DisplayName("Gender")]
        public string Gender { get; set; }
        public List<string> GenderList { get; set; }
        [Required(ErrorMessage = "Date of birth is required")]
        [DisplayName("Date of birth")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        [DisplayName("Phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [DisplayName("Address")]
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Please select a role")]
        [DisplayName("Role")]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public List<Role> RolesList { get; set; }
        public bool Status { get; set; }
    }
}