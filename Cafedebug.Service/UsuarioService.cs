using System.Collections.Generic;
using Cafedebug.Model;
using Cafedebug.Service.Interface;
using log4net;

namespace Cafedebug.Service
{
    /// <summary>
    /// Serviço do Usuário
    /// </summary>
    public class UsuarioService : IUsuarioService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(UsuarioService));

        /// <summary>
        /// Insere um novo usuário
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Save(Usuario obj)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Atualiza um usuario
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Update(Usuario obj)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Exclui um usuário
        /// </summary>
        /// <param name="obj"></param>
        public void Delete(Usuario obj)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Recupera uma lista de usuários
        /// </summary>
        /// <returns></returns>
        public IList<Usuario> GetAll()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// REcupera um usuário por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
