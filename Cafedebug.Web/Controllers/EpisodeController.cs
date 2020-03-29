using log4net;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class EpisodeController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(EpisodeController));
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewEpisode()
        {
            return View();
        }

        public ActionResult GetEpisodies()
        {
            return View();
        }

        public ActionResult MoreEpisode()
        {
            return View();
        }
    }
}