using log4net;

namespace Cafedebug.Data
{
    /// <summary>
    /// Repositório da tbCategoria
    /// </summary>
    public class CategoriaRepository
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(UsuarioRepository));

        private readonly CafedebugContext _contexto;
    }
}
