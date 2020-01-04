using Cafedebug.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafedebug.Data.Mappings
{
    public class BannerMapping : IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(b => b.UrlImagem)
                .IsRequired()
                .HasColumnType("varchar(300)");

            builder.Property(b => b.Url)
               .IsRequired()
               .HasColumnType("varchar(300)");

            builder.Property(b => b.DataInicio)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(b => b.DataFim)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(b => b.Ativo)
                .HasColumnType("bit");

            builder.ToTable("Banner");
        }
    }
}
