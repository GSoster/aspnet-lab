using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Getting_Started_with_ASP.NET_MVC_5.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            //return "This is my <b>default</b> action..."; // version 1
            return View(); // version 2
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            //return "This is the Welcome action method..."; //version 1
            //return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes); // version 2            
            ViewBag.Message = "Hello " + name;
            ViewBag.numTimes = numTimes;

            return View(); //version 3
        }
    }
}