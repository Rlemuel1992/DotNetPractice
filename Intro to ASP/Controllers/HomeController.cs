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
			if (u.Name.Length < 3)
			{
				
				return RedirectToAction("YaDunGoofd");
			}
			else
            return View();
        }
		public ActionResult IWarnedYouDog()
		{
			return View();
		}
		public ActionResult YaDunGoofd()
		{

			ViewBag.YaDunGoofd = "Please don't make me do this.... I just want a real name like 3 letters long, " +
								"I mean I get that it sucks you may be named" +
								"Al, or Jo or something, but just put another letter in there, or something!";
			return View();
		}
		public ActionResult CorrectHorse()
		{
			return View();
		}
    }
}