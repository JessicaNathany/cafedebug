using Cafedebug.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafedebug.Data.Mappings
{
    public class EpisodioMapping : IEntityTypeConfiguration<Episodio>
    {
        public void Configure(EntityTypeBuilder<Episodio> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Titulo)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(b => b.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(b => b.Url)
               .IsRequired()
               .HasColumnType("varchar(250)");

            builder.Property(b => b.UrlImagem)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(b => b.Data)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(b => b.Ativo)
                .HasColumnType("bit");

            builder.ToTable("Episodio");
        }
    }
}