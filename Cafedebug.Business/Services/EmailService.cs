using System;

namespace Cafedebug.Business
{
    /// <summary>
    /// Serviço do Email
    /// </summary>
    public class EmailService
    {
        /// <summary>
        /// Repositório do Usuário
        /// </summary>
        public Lazy<IUsuarioRepository> UsuarioRepository { get; set; }
    }
}
