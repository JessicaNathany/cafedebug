using Cafedebug.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafedebug.Data.Mappings
{
    public class TagMapping : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Nome)
                .IsRequired()
                .HasColumnType("varchar(80)");
            
            builder.ToTable("Tag");
        }
    }
}
