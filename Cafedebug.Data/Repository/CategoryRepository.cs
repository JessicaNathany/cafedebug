using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Data.Context;
using log4net;

namespace Cafedebug.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        
        public CategoryRepository(CafedebugContext context) : base(context)
        { }
    }
}
