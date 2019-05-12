using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class EpisodioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}