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
        public ActionResult homeactor_post(int id, int age, String Fname, String Lname, String Img)
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
        public ActionResult homeactordelete(int id)
        {
            database.deleteActor(id);
            return RedirectToAction("homeactor");
        }
        public ActionResult homedirector()
        {
            return View();
        }
        public ActionResult singleActor(int id)
        {
            Actors a = database.RetriveActor(id);
            List<Movie> listofmovie = database.GetMoviesOfActor(id);
                return View(new actormovies{Actor = a,listofmovies = listofmovie});
        }
        public ActionResult deleteactormovie(int actorid,int movieid)
        {
            database.deleteactormovie(actorid, movieid);
        
            return RedirectToAction("singleActor",new {id=actorid});
        }
        public ActionResult test()
        {

            return View();
        }

    }
}