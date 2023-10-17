using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GIVE_AID.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        [Required]
        public string ImagePath { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        [MaxLength(255)]
        public string Author { get; set; }
        public string TypeOfNews { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Status { get; set; } = true;
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}