using Cafedebug.Model.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// Tela inicial do Login
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {

            return View();
        }

        /// <summary>
        /// Autentica o usuário e redireciona para tela Home
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(UsuarioDTO usuarioDto) 
        {
            return View();
        }

        /// <summary>
        /// Faz o logoff do usuário
        /// </summary>
        /// <returns></returns>
        public ActionResult LogOff()
        {
            return View();

        }

        /// <summary>
        /// Registar uma nova senha para usuário
        /// </summary>
        /// <returns></returns>
        public ActionResult RegisterPassword()
        {
            return View();
        }

        /// <summary>
        /// Reseta a senha do usuário
        /// </summary>
        /// <returns></returns>
        public ActionResult ResetPassword()
        {
            return View();
        }

        /// <summary>
        /// Configura uma nova senha para o usuário esqueci minha senha
        /// </summary>
        /// <returns></returns>
        public ActionResult PasswordForgout()
        {
            return View();
        }

        /// <summary>
        /// Altera a senha do usuário
        /// </summary>
        /// <param name="id"></param>
        /// <param name="senha"></param>
        /// <param name="novaSenha"></param>
        /// <returns></returns>
        public ActionResult ChangePassword(int id, string senha, string novaSenha)
        {
            return View();
        }
    }
}