using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Data.Context;


namespace Cafedebug.Data.Repository
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        private readonly CafedebugContext _context;
        public TeamRepository(CafedebugContext context) : base(context)
        {
            _context = context;
        }
    }
}
