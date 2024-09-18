using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
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

        public ActionResult Project()
        {
            return View();
        }

        public ActionResult Work()
        {
            return View();
        }

		public ActionResult Blog()
		{
			return View();
		}

		public ActionResult Blog1()
		{
			return View();
		}

		public ActionResult Blog2()
		{
			return View();
		}
		public ActionResult Blog3()
		{
			return View();
		}
		public ActionResult Blog4()
		{
			return View();
		}
	}
}