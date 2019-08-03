using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class CategoriaController : Controller
    {
        /// <summary>
        /// Exibe a tela da Categoria
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Exibe a tela de criação da Categoria
        /// </summary>
        /// <returns></returns>
        public ActionResult NovoCategoria()
        {
            return View();
        }
    }
}