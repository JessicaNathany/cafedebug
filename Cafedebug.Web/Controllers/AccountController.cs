using System;
using Cafedebug.Model;
using Cafedebug.Configuration;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// Exibe o formulário de login
        /// </summary>
        /// <returns></returns>
        public IActionResult Login(string login, string senha) //TODO: verificar as diferenças entre IActionResult e AcitonResult
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
        public ActionResult PasswordForget()
        {
            return View();
        }
    }
}