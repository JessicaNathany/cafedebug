using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Exibe a tela para cadastro de usuário
        /// </summary>
        /// <returns></returns>
        public ActionResult CadastrarUsuario()
        {
            return View();
        }
    }
}