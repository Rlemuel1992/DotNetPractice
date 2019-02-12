using Intro_to_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intro_to_ASP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Register page.";
                return View();
        }
        public ActionResult Result(User u)
        {
            ViewBag.Name = u.Name;
            ViewBag.Password = u.Password;
            ViewBag.Age = u.Age;
            ViewBag.Email = u.Email;
            return View();
        }
    }
}