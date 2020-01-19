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

        // GET: Noticia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult NovaNoticia()
        {
            return View();
        }

        public void Save(Noticia noticia)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}