using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GIVE_AID.Models
{
    public class Cause
    {
        [Key]
        public int Id { get; set; }
        public string CauseName { get; set; }
        public bool Status { get; set; } = true;
        public DateTime CreatedDate { get; set; }
        public ICollection<Donation> Donations { get; set; }
    }
}