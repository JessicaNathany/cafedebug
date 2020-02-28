using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class AboutController : Controller
    {
        [Route("quemsomos")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PanelAbout()
        {
            return View();
        }

        public ActionResult NewParticipant()
        {
            return View();
        }

        [Route("atualiza")]
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