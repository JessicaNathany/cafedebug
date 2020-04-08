using log4net;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class AboutController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(AboutController));
        /// <summary>
        /// Tela QuemSomos área do visitante
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult NewParticipant()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {

            return View();
        }

       
        public ActionResult Insert()
        {
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}