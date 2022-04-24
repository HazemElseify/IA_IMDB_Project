using IA_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IA_Project.Controllers
{
    public class adminController : Controller
    {
        // GET: admin
        public ActionResult homemovie()
        {
            return View();
        }
        [ActionName("homeactor")]
        [HttpGet]
        public ActionResult homeactor()
        {
            var listofActors = database.GetActors();
            return View(listofActors);
        }
        [ActionName("homeactor")]
        [HttpPost]
        public ActionResult homeactor_post(int id , int age,String Fname,String Lname,String Img)
        {
            Actors A = new Actors();
            A.id = id;
            A.age = age;
            A.Fname = Fname;
            A.Lname = Lname;
            A.imge = Img;
            database.updateActor(A);
            return RedirectToAction("homeactor");
        }
        public ActionResult homedirector()
        {
            return View();
        }
        public ActionResult test()
        {
            return View();
        }
    }
}