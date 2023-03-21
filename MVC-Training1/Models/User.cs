using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Training1.Models
{
    public enum Countires
    {
        India,
        UK,
        US,
    }
    public class User
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Enter User Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Enter the Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Date Of Birth")]
        [Range(typeof(DateTime), "01-01-1900", "01-01-2090",
                    ErrorMessage = "Date of Birth Must be between 01-01-1970 and 01-01-2005")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        [Display(Name = "Please select a country")]
        public Countires Country { get; set; }
        [Required]
        [Display(Name = "Mention Your Skillset")]
        public string SkillSet { get; set; }
    }
}