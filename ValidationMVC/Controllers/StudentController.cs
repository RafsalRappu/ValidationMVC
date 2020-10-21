using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationMVC.Models;

namespace ValidationMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Validation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Validation(Student student)
        {
            return View("Validation");
        }
    }
}