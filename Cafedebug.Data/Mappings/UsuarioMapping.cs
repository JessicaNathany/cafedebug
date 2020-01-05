using Cafedebug.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafedebug.Data.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Nome)
                .IsRequired()
                .HasColumnType("varchar(80)");

            builder.Property(b => b.Email)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(b => b.Senha)
                .IsRequired()
                .HasColumnType("varchar(400)");

            builder.Property(b => b.Ativo)
               .HasColumnType("bit");

            builder.Property(b => b.UrlImagem)
                .IsRequired()
                .HasColumnType("varchar(200)");
            
            builder.ToTable("Usuario");
        }
    }
}
