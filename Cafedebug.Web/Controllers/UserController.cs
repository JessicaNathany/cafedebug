using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class UserController : Controller
    {
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