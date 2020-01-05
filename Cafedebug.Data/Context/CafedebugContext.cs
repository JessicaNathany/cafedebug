using Cafedebug.Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Cafedebug.Data.Context
{
    /// <summary>
    /// Classe DbContext
    /// </summary>
    public class CafedebugContext : DbContext
    {
        public CafedebugContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Banner> Banners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.Relational().ColumnType = "varchar(100)";

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CafedebugContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
