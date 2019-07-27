using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class EpisodioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Exibe a tela para criar um Novo episódio
        /// </summary>
        /// <returns></returns>
        public ActionResult NovoEpisodio()
        {
            return View();
        }
    }
}