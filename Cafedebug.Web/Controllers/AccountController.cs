using Cafedebug.Configuration;
using Cafedebug.Model;
using Cafedebug.Model.DTO;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Cafedebug.Web.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// Faz a chamada para a tela de login
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            TempData["Mensagem"] = string.Empty;

            return View();
        }

        /// <summary>
        /// Autentica o usuário e redireciona para tela Home
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Login([FromBody]Usuario login) 
        {
            try
            {
                //Autentivar usuário, se estiver correto redirecionar 
                //para a tela Home, senão retornar para a tela de Login e exibir a mensagem de erro

                //IF
                //essa variável tem que ser inserida no arquivo Web.config -  <appSettings><add key="PathCaminhoURL" value="http://localhost:44395/" /></appSettings>
                //string url = ConfigurationManager.AppSettings["PathCaminhoURL"].ToString() + "Home/Index"";
                //return this.Json(url);

                //ELSE
                return this.Json(Mensagem.GetDescription(EnumMensagem.MsgLoginSenhaInc));
            }
            catch (Exception ex)
            {
                return this.Json(Mensagem.GetDescription(EnumMensagem.MsgErroGenerico));
            }
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