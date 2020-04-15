using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Areas.Administrador.Controllers
{
    public class EpisodiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}