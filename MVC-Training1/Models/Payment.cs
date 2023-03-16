using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Training1.Models
{
    public enum Mode
    {
        VISA,
        Master,
        Rupay
    }
    public class Payment
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Card Name")]

        public string Username { get; set; }
        [Required]
        [Display(Name = "Card Number")]
        [RegularExpression("^([0-9]){12}$", ErrorMessage = "Card number must be of length 12")]
        public long CardNumber { get; set; }
        [Required]
        [Display(Name = "Mode Of Payment")]

        public Mode ModeOfPayment { get; set; }

    }
}