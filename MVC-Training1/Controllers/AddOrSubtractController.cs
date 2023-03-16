using MVC_Training1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Training1.Controllers
{
    public class AddOrSubtractController : Controller
    {
        // GET: AddOrSubtract
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Result(AddOrSubtractModels data, string command) {
            if( command == "Add")
            {
                data.Result = data.FirstNumber + data.SecondNumber;
                data.Operation= "Sum";
            } else {

                data.Result = data.FirstNumber - data.SecondNumber;
                data.Operation = "Difference";
            }
            return View(data);
        }
    }
}