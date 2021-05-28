using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vacancy.Models;
using System.Data.Entity;



namespace Vacancy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Details(int? id)
        {
            //  ViewBag.Title = "Home Page";
            return View();
        }
    }
}
