using Cafedebug.Business.Models;

namespace Cafedebug.Business.Interfaces
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        PageResult<Category> GetPaged(PageRequest page);
    }
}
