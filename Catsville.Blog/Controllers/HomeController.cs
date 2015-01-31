using System.Web.Mvc;

namespace Catsville.Blog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return RedirectToAction("News");
        }

        public ActionResult News()
        {
            return View();
        }

        public ActionResult Post()
        {
            return View();
        }

        public ActionResult Comments()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}