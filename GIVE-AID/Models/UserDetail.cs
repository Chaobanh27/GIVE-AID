using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GIVE_AID.Models
{
    public class UserDetail
    {
        [ForeignKey("User")]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual User User { get; set; }
    }
}