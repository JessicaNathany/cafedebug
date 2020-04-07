using log4net;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class CategoryController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(CategoryController));
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewCatecory()
        {
            return View();
        }

        /// <summary>
        /// Exibe a tela com todas as categorias
        /// </summary>
        /// <returns></returns>
        public ActionResult Categories()
        {
            return View();
        }
    }
}