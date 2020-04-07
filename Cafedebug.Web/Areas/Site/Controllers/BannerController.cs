using log4net;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class BannerController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(BannerController));
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewBanner()
        {
            return View();
        }

        public ActionResult Banners()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}
