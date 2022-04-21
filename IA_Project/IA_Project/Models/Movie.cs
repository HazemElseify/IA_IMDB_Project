using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMDB_project.Models
{
    public class Movie
    {

        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string genre { get; set; }
        public string imge { get; set; }
    }
}