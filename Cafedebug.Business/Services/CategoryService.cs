using System;
using log4net;
using Cafedebug.Business.Interfaces;

namespace Cafedebug.Business.Services
{
    public class CategoryService : BaseService, ICategoryService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(CategoryService));
        
        public Lazy<ICategoryRepository> CategoriaRepository { get; set; }

        public CategoryService(INotificador notificador) : base(notificador)
        { }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
