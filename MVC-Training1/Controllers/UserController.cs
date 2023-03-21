using MVC_Training1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Training1.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index(User user)
        {
            ModelState.Clear();
            return View();
        }
        public ActionResult Submit(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", user);
            }
            HttpCookie userNameCookie = new HttpCookie("Name");

            userNameCookie.Values["Name"] = user.Name;

            userNameCookie.Expires = DateTime.Now.AddDays(30);

            Response.Cookies.Add(userNameCookie);

            return RedirectToAction("View", user);
        }
        public ActionResult View(User user)

        {
            if (!ModelState.IsValid)
            {
                return View("Index", user);
            }

            HttpCookie nameCookie = Request.Cookies["Name"];

            string name = nameCookie != null ? nameCookie.Value.Split('=')[1] : "undefined";

            TempData["Username"] = name;

            return View();
        }
    }
}