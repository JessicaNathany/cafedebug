using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Data.Context;
using log4net;

namespace Cafedebug.Data.Repository
{
    public class EpisodioRepository : Repository<Episode>, IEpisodeRepository
    {
        public EpisodioRepository(CafedebugContext context) : base(context)
        {}
    }
}
