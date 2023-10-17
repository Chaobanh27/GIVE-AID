using GIVE_AID.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GIVE_AID.Areas.Admin.Models
{
    public class CausesListModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Cause name is required")]
        public string CauseName { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}