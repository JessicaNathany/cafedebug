using Cafedebug.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafedebug.Data.Mappings
{
    public class NoticiaMapping : IEntityTypeConfiguration<Noticia>
    {
        public void Configure(EntityTypeBuilder<Noticia> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Titulo)
                .IsRequired()
                .HasColumnType("varchar(80)");

            builder.Property(b => b.Descricao)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(b => b.UrlImagem)
                .IsRequired()
                .HasColumnType("varchar(300)");

            builder.Property(b => b.LinkNoticia)
               .IsRequired()
               .HasColumnType("varchar(200)");

            builder.Property(b => b.DataPublicacao)
                .IsRequired()
                .HasColumnType("datetime");
            
            builder.ToTable("Noticia");
        }
    }
}
