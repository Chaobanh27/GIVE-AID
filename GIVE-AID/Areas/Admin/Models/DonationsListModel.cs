using GIVE_AID.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GIVE_AID.Areas.Admin.Models
{
    public class DonationsListModel
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime DonationDate { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public int CauseId { get; set; }
        public string CauseName { get; set; }

    }
}