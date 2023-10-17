using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GIVE_AID.Areas.Admin.Models
{
    public class NewsListModel
    {
        [Key]
        public int Id { get; set; }
        //public string Username { get; set; }
        [MaxLength(255)]
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [MaxLength(255)]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "ImagePath is required")]
        public string ImagePath { get; set; }
        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; }
        [MaxLength(255)]
        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Type of news is required")]
        public string TypeOfNews { get; set; }

        [Required(ErrorMessage = "CreatedDate is required")]
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "ModifiedDate is required")]
        public DateTime ModifiedDate { get; set; }
        [Required(ErrorMessage = "Status is required")]
        public bool Status { get; set; } = true;
        public int UserId { get; set; }
    }
}