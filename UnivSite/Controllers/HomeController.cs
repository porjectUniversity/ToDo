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
        TasksContext taskDb = new TasksContext();

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

        [HttpGet]
        public ActionResult AddNewTask()
        {
            var types = new SelectList(new List<string> {"Tasks" , "Events", "Appointmens", "Notes"});
            ViewBag.Type = types;
        
            return View();
        }
        [HttpPost]
        public ActionResult AddNewTask(Tasks task)
        {
            // saved
            taskDb.tasks.Add(task);
            taskDb.SaveChanges();

            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
    }
}