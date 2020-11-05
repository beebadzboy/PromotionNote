using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Filters;
using WebApplication.Helper;

namespace WebApplication.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            ViewBag.Title = "Login";

            return View();
        }

        //[SessionCheckerFilter(type = typeof(AuthorizeAttribute))]
        public ActionResult Index()
        {
            ViewBag.Title = "Promotion Page";

            //AuthorizeAttribute authorize = SessionHelper.Get<AuthorizeAttribute>();
            //if (authorize == null)
            //{
            //    return RedirectToAction("Login");
            //}

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
