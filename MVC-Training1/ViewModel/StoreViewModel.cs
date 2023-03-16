using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Training1.Models;


namespace MVC_Training1.ViewModel
{
    public class StoreViewModel
    {
        public IEnumerable<SelectListItem> StoreModels { get; set; }
        public String  SelectedItems { get; set; }
    }
}