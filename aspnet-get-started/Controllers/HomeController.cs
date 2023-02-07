using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnet_get_started.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "18:37 Your Risk Evo Test application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "18:37 Your contact page. Woking, Costcutter";

            return View();
        }
    }
}