using Microsoft.AspNetCore.Mvc;
using log4net;
using System;
using Microsoft.AspNetCore.Authorization;
using Cafedebug.Web.Models;

namespace Cafedebug.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(AccountController));

        public ActionResult Login()
        {
            TempData["Mensagem"] = string.Empty;

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public void SaveAccount()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Autentication([FromBody]UsuarioModel model)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    //return this.Json(Mensagem.GetDescription(EnumMensagem.MsgErroErrorSistema));
                }

                //Autenticar usuário, se estiver correto redirecionar 
                //para a tela Home, senão retornar para a tela de Login e exibir a mensagem de erro

                //IF
                //essa variável tem que ser inserida no arquivo Web.config -  <appSettings><add key="PathCaminhoURL" value="http://localhost:44395/" /></appSettings>
                //string url = ConfigurationManager.AppSettings["PathCaminhoURL"].ToString() + "Home/Index"";
                //return this.Json(url);

                //ELSE
                //return this.Json(Mensagem.GetDescription(EnumMensagem.MsgLoginSenhaIncorreto));
                return Json("");
            }
            catch (Exception)
            {
                return Json("");
            }
        }

        public ActionResult LogOff()
        {
            return View();
        }

        public ActionResult NewPassword(string returnUrl)
        {
            return View();
        }

       
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

        public ActionResult ResetPassword()
        {
            return View();
        }

        public ActionResult PasswordForgout()
        {
            return View();
        }

        public ActionResult ChangePassword(int id, string senha, string novaSenha)
        {
            return View();
        }
    }
}
    
