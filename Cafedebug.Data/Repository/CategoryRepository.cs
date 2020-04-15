using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Data.Context;

namespace Cafedebug.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        
        public CategoryRepository(CafedebugContext context) : base(context)
        { }

        public PageResult<Category> GetPaged(PageRequest page)
        {
            return new PageResult<Category>();
        }
    }
}
