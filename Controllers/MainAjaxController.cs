using studAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace studAjax.Controllers
{
    public class MainAjaxController : Controller
    {
        stAjQ_Db db = new stAjQ_Db();
        // GET: MainAjax
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StudentList(int take, int skip)
        {
            object data = null;
            var modelist = db.Studentsses.OrderBy(st => st.StudentName).Skip(skip).Take(take).Select(st => new
            {
                st.Id,
                st.StudentName,
                st.StudentEmail,
                st.StudentPhone
            }).ToList();
            data = new
            {
                status = 200,
                message = "succes",
                response = modelist
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}