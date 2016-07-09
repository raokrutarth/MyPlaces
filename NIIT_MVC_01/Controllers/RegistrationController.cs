using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPlaces.Models;

namespace MyPlaces.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult Welcome()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
       [HttpPost]
        public ActionResult Create(Customer customer)
        {
           if(ModelState.IsValid)
            return RedirectToAction("Welcome");
           return View();
        }
    }
}
