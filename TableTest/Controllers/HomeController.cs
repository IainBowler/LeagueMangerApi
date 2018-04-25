using System.Web.Mvc;

namespace TableTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            string[][] bob = {new string[] {"One", "Two", "Three"}, new string[] { "Four", "Five", "Six" }, new string[] { "Seven", "Eight", "Nine" } };
            ViewBag.Message = "Your application description page.";

            return View(bob);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}