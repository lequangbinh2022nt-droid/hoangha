using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hoangha.Controllers
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

            return View();
        }
        public ActionResult b1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult pcgiare()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult cpu()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult vag()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult lkmt()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult mhmt()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult tncoling()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult tbm()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}