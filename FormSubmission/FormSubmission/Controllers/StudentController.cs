using FormSubmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormSubmission.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult Index(Student s)
        {
            if (ModelState.IsValid)
            {
                //return RedirectToAction("Index", "Home");
                ViewBag.V = "Valid";
            }
            return View(s);
        }
    }
}