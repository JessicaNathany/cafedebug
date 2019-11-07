using Microsoft.EntityFrameworkCore;

namespace Cafedebug.Repository
{
    /// <summary>
    /// classe de contexto
    /// </summary>
    public class CafedebugContext : DbContext
    {
        public CafedebugContext(DbContextOptions<CafedebugContext> options)
            : base(options)
        { }
    }
}
