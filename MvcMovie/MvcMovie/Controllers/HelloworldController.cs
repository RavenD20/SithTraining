using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Sql;
using System.Data.SqlClient;


namespace MvcMovie.Controllers
{
    public class HelloworldController : Controller
    {
        // GET: Helloworld
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Arcade()
        {
          return View();
        }

        public ActionResult SpaceInvaders()
        {
            return View();
        }

        

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}