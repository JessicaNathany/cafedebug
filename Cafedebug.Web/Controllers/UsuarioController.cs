using System;
using Cafedebug.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Exibe a tela para cadastrar um novo usuário
        /// </summary>
        /// <returns></returns>
        public ActionResult NovoUsuario()
        {
            return View();
        }

        /// <summary>
        /// Salva um usuário
        /// </summary>
        /// <returns></returns>
        public void Save(tbUsuario usuario)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Atauliza um usuário
        /// </summary>
        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Exclui um usuário
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Exibe um grid com todos os usuários
        /// </summary>
        /// <returns></returns>
        public ActionResult GetUsuario()
        {
            return View();
        }

        /// <summary>
        /// Recupera uma lista de usuários
        /// </summary>
        /// <returns></returns>
        public IList<tbUsuario>GetAllUsuario()
        {
            throw new NotImplementedException(); 
        }

        /// <summary>
        /// Recupera um obj usuário pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public tbUsuario GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}