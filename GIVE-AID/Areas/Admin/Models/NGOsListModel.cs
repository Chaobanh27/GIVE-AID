using GIVE_AID.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GIVE_AID.Areas.Admin.Models
{
    public class NGOsListModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "city is required")]
        public string City { get; set; }
        [Required(ErrorMessage = "country is required")]
        public string Country { get; set; }
        [Required(ErrorMessage = "email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "phone is required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "status is required")]
        public bool Status { get; set; }
        public int UserId { get; set; }
    }
}