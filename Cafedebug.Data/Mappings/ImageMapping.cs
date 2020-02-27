using Cafedebug.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafedebug.Data.Mappings
{
    public class ImageMapping : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(i => i.Id);

           builder.Property(i => i.UrlImage)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(i => i.Type)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.ToTable("Image");
        }
    }
}
