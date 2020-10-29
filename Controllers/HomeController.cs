using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Promotion Page";

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Title = "Create Promotion Page";

            return View();
        }

        public ActionResult Edit()
        {
            ViewBag.Title = "Edit Promotion Page";

            return View();
        }
    }
}
