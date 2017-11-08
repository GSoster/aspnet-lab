using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Getting_Started_with_ASP.NET_MVC_5.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}