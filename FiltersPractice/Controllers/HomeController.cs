using FiltersPractice.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersPractice.Controllers
{
    public class HomeController : Controller
    {
        [CustomAuth(false)]
        public String Index()
        {
            return "This is the Index of the action on the Home Controller";
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
    }
}