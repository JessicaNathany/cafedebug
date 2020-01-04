using log4net;
using System;
using Cafedebug.Business.Interfaces;

namespace Cafedebug.Business.Services
{
    /// <summary>
    /// Serviço do Usuário
    /// </summary>
    public class UsuarioService : BaseService, IUsuarioService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(UsuarioService));

        public UsuarioService(INotificador notificador) : base(notificador)
        { }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
