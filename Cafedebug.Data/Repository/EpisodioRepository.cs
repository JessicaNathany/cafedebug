using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Data.Context;
using log4net;

namespace Cafedebug.Data.Repository
{
    public class EpisodioRepository : Repository<Episode>, IEpisodeRepository
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(UsuarioRepository));

        public EpisodioRepository(CafedebugContext context) : base(context)
        {}
    }
}
