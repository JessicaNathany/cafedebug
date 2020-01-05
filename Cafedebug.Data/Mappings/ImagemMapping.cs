using Cafedebug.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafedebug.Data.Mappings
{
    public class ImagemMapping : IEntityTypeConfiguration<Imagem>
    {
        public void Configure(EntityTypeBuilder<Imagem> builder)
        {
            builder.HasKey(i => i.Id);

           builder.Property(i => i.UrlImagem)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(i => i.Tipo)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.ToTable("Imagem");
        }
    }
}
