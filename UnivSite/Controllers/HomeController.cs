using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnivSite.Models;

namespace UnivSite.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calender()
        {
            return View();
        }

        public ActionResult Lists()
        {
            return View();
        }

        public ActionResult Goals()
        {
            return View();
        }

        public ActionResult Achievements()
        {
            return View();
        }
    }
}