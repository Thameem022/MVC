using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Training1.Models
{
    public class AddOrSubtractModels
    {
        [Display (Name = "Enter First number" )]
        public int FirstNumber { get; set; }
        [Display(Name = "Enter Second number")]

        public int SecondNumber { get; set; }
        public int Result { get; set; }

        public string Operation { get; set; }
    }
}