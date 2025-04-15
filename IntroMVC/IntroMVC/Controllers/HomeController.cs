using IntroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

            TempData["msg"] = "Redirected from Contact";
            return RedirectToAction("Students");
            return View();
        }

        public ActionResult Students()
        {
            ViewBag.s1Name = "Nahid";

            ViewData["s2Name"] = "Sakib";

            Student s1 = new Student(){
                Id = 1,
                Name = "Nahid"
            };

            Student s2 = new Student()
            {
                Id = 2,
                Name = "Fahim"
            };

        Student[] students = new Student[] {s1 , s2};


        

            return View(students);
        }   
    }
}