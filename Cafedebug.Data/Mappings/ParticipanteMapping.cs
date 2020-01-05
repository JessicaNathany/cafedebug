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
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(b => b.UrlLinkedin)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(b => b.UrlImagem)
               .IsRequired()
               .HasColumnType("varchar(200)");

            builder.Property(b => b.Bio)
                .IsRequired()
                .HasColumnType("varchar(300)");
            
            builder.ToTable("Participante");
        }
    }
}
