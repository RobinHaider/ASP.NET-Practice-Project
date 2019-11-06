using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jquery_Data_Table___CSharpCorner.Models;

namespace Jquery_Data_Table___CSharpCorner.Controllers
{
    public class StudentController : Controller
    {
        DatabaseContext db = new DatabaseContext();

        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //Get student list for jquery DataTable
        public ActionResult GetStudentList()
        {
            var students = db.Students.ToList();

            return Json(new { data = students }, JsonRequestBehavior.AllowGet);
        }
    }
}