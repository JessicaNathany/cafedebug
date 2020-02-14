using System;
using System.Collections.Generic;
using Cafedebug.Business;
using Cafedebug.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NovoUsuario()
        {
            return View();
        }

        public void Save(Usuario usuario)
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

        public ActionResult UsuarioEdit()
        {
            return View();
        }

        public IList<Usuario>GetAllUsuario()
        {
            throw new NotImplementedException(); 
        }

        public Usuario GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}