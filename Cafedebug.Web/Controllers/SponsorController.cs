using System;
using Cafedebug.Business.Models;
using log4net;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class NoticiaController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(NoticiaController));


        public ActionResult Index()
        {
            return View();
        }
    }
}