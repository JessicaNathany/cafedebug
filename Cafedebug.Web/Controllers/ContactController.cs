using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}