using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Data.Context;
using System.Linq.Dynamic.Core;
using System.Linq;

namespace Cafedebug.Data.Repository
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        private readonly CafedebugContext _context;
        public TeamRepository(CafedebugContext context) : base(context)
        {
            _context = context;
        }

        public PageResult<Team> GetPaged(PageRequest page)
        {
            var result = _context.Team
                                    .OrderBy($"{page.SortBy}")
                                    .Skip(page.ItemsPerPage * (page.Page))
                                    .Take(page.ItemsPerPage)
                                    .ToList();

            var count = Count();

            return new PageResult<Team>(page.ItemsPerPage, count, result);
        }
    }
}
