using System;
using log4net;
using Cafedebug.Business.Interfaces;

namespace Cafedebug.Business.Services
{
    public class CategoriaService : BaseService, ICategoriaService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(CategoriaService));
        
        public Lazy<ICategoriaRepository> CategoriaRepository { get; set; }

        public CategoriaService(INotificador notificador) : base(notificador)
        { }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
