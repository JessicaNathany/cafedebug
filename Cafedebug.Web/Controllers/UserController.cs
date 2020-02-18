using System;
using System.Collections.Generic;
using Cafedebug.Business;
using Cafedebug.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewUser()
        {
            return View();
        }

        public void Save(User usuario)
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

        public ActionResult UserEdit()
        {
            return View();
        }

        public IList<User>GetAllUser()
        {
            throw new NotImplementedException(); 
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}