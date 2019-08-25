using Cafedebug.Configuration;
using Cafedebug.Model;
using Cafedebug.Model.DTO;
using Microsoft.AspNetCore.Mvc;
using log4net;
using System;

namespace Cafedebug.Web.Controllers
{
    public class AccountController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(AccountController));

        /// <summary>
        /// Faz a chamada para a tela de login
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            TempData["Mensagem"] = string.Empty;

            return View();
        }

        /// <summary>
        /// Exibe os dados da tela Minha Conta
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Salva os dados da conta
        /// </summary>
        /// <returns></returns>
        public void SaveAccount()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Autentica o usuário e redireciona para tela Home
        /// </summary>
        /// <param name="usuarioDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Autentication([FromBody]UsuarioDTO usuarioDto)
        {
            try
            {
                //Autenticar usuário, se estiver correto redirecionar 
                //para a tela Home, senão retornar para a tela de Login e exibir a mensagem de erro

                //IF
                //essa variável tem que ser inserida no arquivo Web.config -  <appSettings><add key="PathCaminhoURL" value="http://localhost:44395/" /></appSettings>
                //string url = ConfigurationManager.AppSettings["PathCaminhoURL"].ToString() + "Home/Index"";
                //return this.Json(url);

                //ELSE
               return this.Json(Mensagem.GetDescription(EnumMensagem.MsgLoginSenhaIncorreto));
            
            }
            catch (Exception)
            {
                return this.Json(Mensagem.GetDescription(EnumMensagem.MsgErroGeneric));
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
        [HttpGet]
        public ActionResult NewPassword(string returnUrl)
        {
            return View();
        }

        /// <summary>
        /// Quando chamado via Post, envia uma nova senha por e-mail para o usuário.
        /// </summary>
        /// <param name="email">E-mail do usuário.</param>
        /// <param name="returnUrl">Url para redirecionar após fazer login com sucesso.</param>
        /// <returns>Json.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewPassword(string email, string returnUrl)
        {
            throw new NotImplementedException();

            // criar arquivos UrlRota => rota dos controllers + index

            //try
            //{
            //    var notification = new Notification()
            //    {
            //        Type = NotificationType.Success,
            //        Message = PRW.Resources.Account.NewPassword_SuccessMessageHtml,
            //        Expiration = 10
            //    };
            //    this.AddNotification(notification);

            //    return JsonResultHelper.Redirect(Url.Account().Login(returnUrl).ToString());
            //}
            //catch (Exception ex)
            //{
            //    Log.Error("Erro ao enviar nova senha para o usuário '{0}'.".FormatWith(email), ex);
             //   return JsonResultHelper.Exception("Nova senha enviada com sucesso!");
            //}
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
    
