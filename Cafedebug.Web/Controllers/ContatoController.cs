using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class ContatoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}