using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StyleChanger.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (!ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("test"))
            {
                HttpCookie cookie = new HttpCookie("test");
                cookie.Value = "1";
                ControllerContext.HttpContext.Response.Cookies.Add(cookie);
            }

            return View();
        }

        public ActionResult Layout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Components()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Styles()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ToggleStyleSheet()
        {
            if (ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("test"))
            {
                if(ControllerContext.HttpContext.Request.Cookies["test"].Value == "1")
                {
                    HttpCookie cookie = new HttpCookie("test");
                    cookie.Value = "2";
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);
                }
                else
                {
                    HttpCookie cookie = new HttpCookie("test");
                    cookie.Value = "1";
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);
                }
            }

            return RedirectToAction("Index", "Home");
        }
    }
}