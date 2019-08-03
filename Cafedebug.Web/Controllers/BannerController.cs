using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafedebug.Web.Controllers
{
    public class BannerController : Controller
    {
        /// <summary>
        /// Exibe a tela do Banner
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Exibe a tela para cadastrar um novo Banner
        /// </summary>
        /// <returns></returns>
        public ActionResult NovoBanner()
        {
            return View();
        }

        /// <summary>
        /// Recupera os dados do Banner na tela 
        /// </summary>
        /// <returns></returns>
        public ActionResult GetBanner()
        {
            return View();
        }
    }
}
