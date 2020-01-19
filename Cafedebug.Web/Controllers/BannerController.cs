using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class BannerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NovoBanner()
        {
            return View();
        }

        public ActionResult Banner()
        {
            return View();
        }
    }
}
