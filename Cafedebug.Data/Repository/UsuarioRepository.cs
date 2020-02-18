using log4net;
using Cafedebug.Business.Interfaces;
using Cafedebug.Data.Context;
using Cafedebug.Business.Models;

namespace Cafedebug.Data.Repository
{
    public class UsuarioRepository : Repository<User>, IUsuarioRepository
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(UsuarioRepository));

        public UsuarioRepository(CafedebugContext context) : base(context)
        {}
    }
}
