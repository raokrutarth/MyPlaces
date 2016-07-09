using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPlaces.Models;

namespace MyPlaces.Controllers
{
    public class PlacesController : Controller
    {
        public ActionResult Index()
        {
            var Places = MyPlaces.MvcApplication.Places;
            return View(Places);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.category = new SelectList(new[] { "Residential", "Office", "Commercial", "Agricultural" });
            return View();
        }
        [HttpPost]
        public ActionResult Create(Place place)
        {
            MyPlaces.MvcApplication.Places.Add(place);
            return RedirectToAction("Index");
        }
    }
}