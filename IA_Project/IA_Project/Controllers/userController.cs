using IMDB_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMDB_project.Controllers
{
    public class userController : Controller
    {
        // GET: user
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            List<Movie> movie = new List<Movie>
            {
                new Movie{ name ="TARZAN" ,
                    desc = "Tarzan, having acclimated to life in London, is called back to his former home in the jungle to investigate the activities at a mining encampment." ,
                    genre = "Action",
                    imge = "../images/5.jpg",
                },
                new Movie{ name ="THE LEGEND OF TARZAN" ,
                    desc = "Tarzan, having acclimated to life in London, is called back to his former home in the jungle to investigate the activities at a mining encampment." ,
                    genre = "Action",
                    imge = "../images/5.jpg",
                },
                new Movie{ name ="THE LEGEND OF TARZAN" ,
                    desc = "Tarzan, having acclimated to life in London, is called back to his former home in the jungle to investigate the activities at a mining encampment." ,
                    genre = "Action",
                    imge = "../images/5.jpg",
                }
            };
            return View(movie);
        }

        

        }
}