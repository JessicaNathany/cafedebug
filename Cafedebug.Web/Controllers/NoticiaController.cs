using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cafedebug.Model;

namespace Cafedebug.Web.Controllers
{
    public class NoticiaController : Controller
    {
        /// <summary>
        /// Exibe a tela de Noticias 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        // GET: Noticia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        /// <summary>
        /// Exibe a tela Nova Noticia
        /// </summary>
        /// <returns></returns>
        public ActionResult NovaNoticia()
        {
            return View();
        }

        /// <summary>
        /// Salva uma nova noticia na base
        /// </summary>
        public void Save(tbNoticia noticia)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Atualiza uma noticia
        /// </summary>
        /// <param name="id"></param>
        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Exclui uma Noticia 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}