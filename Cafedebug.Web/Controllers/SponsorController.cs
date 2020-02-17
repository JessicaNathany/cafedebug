using System;
using Cafedebug.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class NoticiaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}