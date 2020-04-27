using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Areas.Adm.Controllers
{
    [Area("administrador")]
    public class DashboardController : Controller
    {
        public DashboardController()
        {
            // do stuff
        }

        public ActionResult Index()
        {
            return View();
        }

    }
    }
