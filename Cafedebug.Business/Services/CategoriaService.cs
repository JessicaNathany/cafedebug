using System;
using log4net;
using Cafedebug.Business.Interfaces;

namespace Cafedebug.Business.Services
{
    /// <summary>
    /// Servicço da Categoria
    /// </summary>
    public class CategoriaService : BaseService, ICategoriaService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(CategoriaService));
        
        /// <summary>
        /// Repositório Categoria
        /// </summary>
        public Lazy<ICategoriaRepository> CategoriaRepository { get; set; }

        public CategoriaService(INotificador notificador) : base(notificador)
        { }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
