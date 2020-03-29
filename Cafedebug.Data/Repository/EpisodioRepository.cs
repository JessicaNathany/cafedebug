using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Data.Context;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace Cafedebug.Data.Repository
{
    public class EpisodioRepository : Repository<Episode>, IEpisodeRepository
    {
        private readonly CafedebugContext _context;
        public EpisodioRepository(CafedebugContext context) : base(context)
        {
            _context = context;
        }

        public PageResult<Episode> GetPaged(PageRequest page)
        {
            var result = _context.Episodes
                                    .OrderBy($"{page.SortBy}")
                                    .Skip(page.ItemsPerPage * (page.Page - 1))
                                    .Take(page.ItemsPerPage)
                                    .ToList();

            var count = Count();

            return new PageResult<Episode>(page.ItemsPerPage, count, result);
        }
    }
}
