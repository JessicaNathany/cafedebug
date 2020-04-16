using Cafedebug.Web.Models;
using log4net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Cafedebug.Web.Controllers
{
    public class ContactController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(ContactController));


        public ActionResult Index()
        {
            var model = new ContactViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult ContactUs()
        {
            var obj = "";
            
            return Json(obj);
        }
    }
}