using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
		

        public ActionResult Index()
        {
			if (User.Identity.IsAuthenticated == true)
				{
					return View("IndexSignedIn");
				}
			return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
			if (User.Identity.IsAuthenticated == true)
			{
				return View("AboutSignedIn");
			}

			return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
			if (User.Identity.IsAuthenticated == true)
			{
				return View("ContactSignedIn");
			}

			return View();
        }
    }
}