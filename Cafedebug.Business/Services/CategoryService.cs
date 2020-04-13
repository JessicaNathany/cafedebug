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

        public void Update(Category category)
        {
            try
            {
                if (!ExecuteValidation(new CategoryValidation(), category)) return;

                _categoriaRepository.Update(category);
            }
            catch (Exception ex)
            {
                Notify("Erro ao atualizar a categoria");
                Log.ErrorFormat("Erro ao atualizar a categoria", ex.Message, category);
                throw;
            }
        }

        public void Remove(int id)
        {
           _categoriaRepository.Delete(id);
        }

        public void GetById(int id)
        {
             _categoriaRepository.GetById(id);
        }

        public void Dispose()
        {
            _categoriaRepository?.Dispose();
        }

        public PageResult<Category> GetPaged(PageRequest page)
        {
            return _categoriaRepository.GetPaged(page);
        }
    }
}
