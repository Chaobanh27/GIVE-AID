using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GIVE_AID.Models
{
    public class Donation
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime DonationDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CauseId { get; set; }
        public Cause Cause { get; set; }
    }
}