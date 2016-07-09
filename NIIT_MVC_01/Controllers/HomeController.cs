using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPlaces.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult SuggestedPlaces()
        {
            string[] UpcomingCourses = { "Home", "School", "Dorms" };
            string[] Venues = { "Link", "Link", "Link", "Link" };
            ViewBag.names = UpcomingCourses;
            ViewBag.venues = Venues;
            return View();
        }
        
    }
}