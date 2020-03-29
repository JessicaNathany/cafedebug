using log4net;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class UserController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(UserController));

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewUser()
        {
            return View();
        }
    }
}