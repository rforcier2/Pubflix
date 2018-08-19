using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pubflix.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Customers()
        {
            ViewBag.Message = "Manage all of your Customers in one, convenient location.";

            return View();
        }

        public ActionResult Movies()
        {
            ViewBag.Message = "Manage your available movie content all in one place.";

            return View();
        }
        public ActionResult Register()
        {
            ViewBag.Message = "Your register or login portal.";

            return View();
        }

    }
}