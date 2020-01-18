using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Data.Context;
using log4net;

namespace Cafedebug.Data.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(UsuarioRepository));

        public CategoriaRepository(CafedebugContext context) : base(context)
        { }
    }
}
