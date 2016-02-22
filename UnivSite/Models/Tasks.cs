using System;
using System.ComponentModel.DataAnnotations;

namespace UnivSite.Models
{
    public class Tasks
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yy/MM/dd}")]
        public DateTime DateTime { get; set; }

        [Required]
        public string Description { get; set; }
    }
}