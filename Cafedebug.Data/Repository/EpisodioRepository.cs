using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Data.Context;
using log4net;

namespace Cafedebug.Data.Repository
{
    /// <summary>
    /// Repositório do tbPublicação
    /// </summary>
    public class EpisodioRepository : Repository<Episodio>, IEpisodioRepository
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(UsuarioRepository));

        public EpisodioRepository(CafedebugContext context) : base(context)
        {}
    }
}
