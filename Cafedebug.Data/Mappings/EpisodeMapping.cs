using Cafedebug.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafedebug.Data.Mappings
{
    public class EpisodeMapping : IEntityTypeConfiguration<Episode>
    {
        public void Configure(EntityTypeBuilder<Episode> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Title)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(b => b.Description)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(b => b.Url)
               .IsRequired()
               .HasColumnType("varchar(250)");

            builder.Property(b => b.ImageUrl)
                .IsRequired();

            builder.Property(b => b.PublicationDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(b => b.UpdateDate)
            .IsRequired()
            .HasColumnType("datetime");

            builder.Property(b => b.Ative)
                .HasColumnType("bit");

            builder.ToTable("Episode");
        }
    }
}