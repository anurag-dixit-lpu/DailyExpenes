using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace DailyExpenes.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.WEB_API_URL_PART = ConfigurationManager.AppSettings["WEB_API_URL_PART"];

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
	}
}