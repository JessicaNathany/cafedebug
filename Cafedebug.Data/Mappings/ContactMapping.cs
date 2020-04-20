using Cafedebug.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafedebug.Data.Mappings
{
    public class ContactMapping : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasColumnType("varchar(50)");


            builder.Property(b => b.Email)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(b => b.Message)
                .IsRequired()
                .HasColumnType("varchar(500)");
        }
    }
}
