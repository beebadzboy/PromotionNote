using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class ShowController : Controller
    {
        // GET: Show
        public ActionResult Index()
        {
            ViewBag.Title = "Index";

            return View();
        }

        public ActionResult Detail()
        {
            ViewBag.Title = "Detail";

            return View();
        }
    }
}