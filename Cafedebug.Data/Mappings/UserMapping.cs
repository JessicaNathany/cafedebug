using Cafedebug.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafedebug.Data.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasColumnType("varchar(80)");

            builder.Property(b => b.Email)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(b => b.Login)
                .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(b => b.Password)
                .IsRequired()
                .HasColumnType("varchar(400)");

            builder.Property(b => b.Ative)
               .HasColumnType("bit");

            builder.Property(b => b.ImageId)
                .IsRequired();
            
            builder.ToTable("User");
        }
    }
}
