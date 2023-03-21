using MVC_Training1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Training1.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult AddCard(Payment PaymentMode)
        {
            if (!ModelState.IsValid)
            {
                return View("AddCard", PaymentMode);

            }
            ModelState.Clear();
            return View();
        }
    }
}