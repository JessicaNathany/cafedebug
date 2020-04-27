using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Areas.Adm.Controllers
{
    [Area(nameof(Administrador))]
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
