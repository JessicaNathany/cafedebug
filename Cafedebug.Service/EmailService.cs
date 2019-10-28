using System;
using System.Collections.Generic;
using Cafedebug.Model;
using Cafedebug.Service.Interface;
using log4net;
using Cafedebug.Repository.Interface;
using Unity;

namespace Cafedebug.Service
{
    /// <summary>
    /// Serviço do Email
    /// </summary>
    public class EmailService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(EmailService));

        /// <summary>
        /// Repositório do Usuário
        /// </summary>
        [Dependency]
        public Lazy<IUsuarioRepository> UsuarioRepository { get; set; }
    }
}
