using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafedebug.Web.Areas.Adm.Controllers
{
    public class AdminController : Controller
    {
        public AdminController()
        {
            // do stuff
        }

        public ActionResult Index()
        {
            return View();
        }

    }
    }
