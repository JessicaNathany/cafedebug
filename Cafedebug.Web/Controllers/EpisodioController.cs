using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class EpisodioController : Controller
    {
        /// <summary>
        /// Exibe a página de episódios frontend
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// Exibe a tela para listar os episódios frontend
        /// </summary>
        /// <returns></returns>
        public ActionResult GetEpisodios()
        {
            return View();
        }
    }
}