using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatePickerTest.Controllers
{
    public class DateController : Controller
    {
        // GET: Date
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult IndexPost(DatePickerTest.Models.DateModel myDate)
        {
            return Json(new { Result = "OK" });
        }

    }
}