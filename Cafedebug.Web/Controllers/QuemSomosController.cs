using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class QuemSomosController : Controller
    {
        /// <summary>
        /// Exibe a tela QuemSomos
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Exibe a tela QuemSomos do painel de controle
        /// </summary>
        /// <returns></returns>
        public ActionResult QuemSomosPainel()
        {
            return View();
        }

        /// <summary>
        /// Adiciona um novo participante na tela de Quem Somos
        /// </summary>
        /// <returns></returns>
        public ActionResult NovoParticipante()
        {
            return View();
        }

        /// <summary>
        /// Exibe a tela para edição do painel de controle
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit()
        {

            return View();
        }

        /// <summary>
        /// Insere um novo registro (pessoa) na tela QuemSomos
        /// </summary>
        /// <returns></returns>
        public ActionResult Insert()
        {
            return View();
        }

        /// <summary>
        /// Atualiza um registro (pessoa) na tela QuemSomos
        /// </summary>
        /// <returns></returns>
        public ActionResult Update()
        {
            return View();
        }

        /// <summary>
        /// Exclui um registro (pessoa) na tela QuemSomos
        /// </summary>
        /// <returns></returns>
        public ActionResult Delete()
        {
            return View();
        }
    }
}