using System;
using log4net;
using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Business.Validations;

namespace Cafedebug.Business.Services
{
    public class CategoryService : BaseService, ICategoryService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(CategoryService));
        
        public Lazy<ICategoryRepository> CategoriaRepository { get; set; }

        public CategoryService(INotifier notifier) : base(notifier)
        { }

        public void Save(Category category)
        {
            if (!ExecutarValidacao(new CategoryValidation(), category)) return;

            CategoriaRepository.Value.Save(category);
        }

        public Category Update(Category category)
        {
            throw new NotImplementedException();
        }

        public Category Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
