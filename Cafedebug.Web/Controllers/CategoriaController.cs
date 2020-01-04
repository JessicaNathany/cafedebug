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

        /// <summary>
        /// Exibe um grid com todas as categorias na tela
        /// </summary>
        /// <returns></returns>
        public ActionResult GetCategoria()
        {
            return View();
        }
    }
}