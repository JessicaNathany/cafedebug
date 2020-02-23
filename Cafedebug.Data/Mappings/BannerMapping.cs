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

            builder.Property(b => b.Name)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(b => b.ImageId)
                .IsRequired();

            builder.Property(b => b.Url)
               .IsRequired()
               .HasColumnType("varchar(300)");

            builder.Property(b => b.StartDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(b => b.EndDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(b => b.Active)
                .HasColumnType("bit");

            builder.ToTable("Banner");
        }
    }
}