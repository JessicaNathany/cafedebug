using Cafedebug.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafedebug.Data.Mappings
{
    public class ParticipanteMapping : IEntityTypeConfiguration<Participante>
    {
        public void Configure(EntityTypeBuilder<Participante> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Nome)
                .IsRequired()
                .HasColumnType("varchar(80)");

            builder.Property(b => b.UrlTwitter)
                .HasColumnType("varchar(200)");

            builder.Property(b => b.UrlLinkedin)
                .HasColumnType("varchar(200)");

            builder.Property(b => b.ImagemId)
               .IsRequired();

            builder.Property(b => b.Bio)
                .IsRequired()
                .HasColumnType("varchar(300)");
            
            builder.ToTable("Participante");
        }
    }
}
