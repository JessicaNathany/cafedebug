using Cafedebug.Business.Models;

namespace Cafedebug.Business.Interfaces
{
    public interface IEpisodeRepository : IBaseRepository<Episode>
    {
        PageResult<Episode> GetPaged(PageRequest page);
    }
}
