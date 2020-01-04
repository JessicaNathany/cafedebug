using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class PatrocinadoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}