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
        public ActionResult homeactor()
        {
            return View();
        }
        public ActionResult homedirector()
        {
            return View();
        }
    }
}