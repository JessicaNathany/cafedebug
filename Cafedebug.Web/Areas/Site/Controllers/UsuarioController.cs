using System;
using System.Collections.Generic;
using log4net;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(UsuarioController));

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NovoUsuario()
        {
            return View();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult GetUsuario()
        {
            return View();
        }
    }
}