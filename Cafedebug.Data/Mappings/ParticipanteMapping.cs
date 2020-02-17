using Cafedebug.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafedebug.Data.Mappings
{
    public class ParticipanteMapping : IEntityTypeConfiguration<Sponsor>
    {
        public void Configure(EntityTypeBuilder<Sponsor> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Nome)
                .IsRequired()
                .HasColumnType("varchar(80)");

            builder.Property(b => b.UrlTwitter)
                .HasColumnType("varchar(200)");

            builder.Property(b => b.UrlLinkedin)
                .HasColumnType("varchar(200)");

            builder.Property(b => b.ImageId)
               .IsRequired();

            builder.Property(b => b.Bio)
                .IsRequired()
                .HasColumnType("varchar(300)");
            
            builder.ToTable("Sponsor");
        }
    }
}
