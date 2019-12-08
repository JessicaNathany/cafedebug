using Cafedebug.Model;
using Microsoft.EntityFrameworkCore;

namespace Cafedebug.Repository
{
    /// <summary>
    /// Classe DbContext
    /// </summary>
    public class CafedebugContext : DbContext
    {
        public CafedebugContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Banner> Banner { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Email> Email { get; set; }

        public DbSet<Episodio> Episodio { get; set; }

        public DbSet<Noticia> Noticia { get; set; }

        public DbSet<Participante> Participante { get; set; }

        public DbSet<Perfil> Perfil { get; set; }

        public DbSet<Tag> Tag { get; set; }

        public DbSet<TipoCategoria> TipoCategoria { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        
    }
}
