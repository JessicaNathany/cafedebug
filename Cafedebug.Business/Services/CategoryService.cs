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

        public Category Save(Category category)
        {
            var validator = new CategoryValidation();
            var result = validator.Validate(category);


            throw new NotImplementedException();
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
