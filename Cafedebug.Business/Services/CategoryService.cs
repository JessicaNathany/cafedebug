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

        private readonly ICategoryRepository _categoriaRepository;

        public CategoryService(ICategoryRepository categoryRepository, INotifier notifier) : base(notifier)
        {
            _categoriaRepository = categoryRepository;
        }

        public void Save(Category category)
        {
            if(!ExecuteValidation(new CategoryValidation(), category)) return;

            _categoriaRepository.Save(category);
        }

        public Category Update(Category category)
        {
            throw new NotImplementedException();
        }

        public Category Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            return _categoriaRepository.GetById(id);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
