using studAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace studAjax.Controllers
{
    public class HomeController : Controller
    {
        stAjQ_Db db = new stAjQ_Db();

        public ActionResult Index()
        {
            ViewBag.StuAjax = db.Studentsses.Take(3).ToList();
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
    }
}