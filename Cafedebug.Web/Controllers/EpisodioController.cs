using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class EpisodioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NovoEpisodio()
        {
            return View();
        }

        public ActionResult GetEpisodios()
        {
            return View();
        }

        public ActionResult MaisEpisodios()
        {
            return View();
        }
    }
}