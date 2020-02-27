using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class CategoryController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NovoCategoria()
        {
            return View();
        }

        public ActionResult GetCategoria()
        {
            return View();
        }
    }
}