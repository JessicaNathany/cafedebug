using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class CategoriaController : Controller
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