using Cafedebug.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafedebug.Data.Mappings
{
    public class EpisodeTagMapping : IEntityTypeConfiguration<EpisodeTag>
    {
        public void Configure(EntityTypeBuilder<EpisodeTag> builder)
        {
            builder.HasKey(b => b.Id);

            builder.HasOne(ep => ep.Episodio)
                .WithMany(et => et.EpisodiesTags)
                .HasForeignKey(e => e.EpisodioId);

            builder.HasOne(ep => ep.Tag)
                .WithMany(et => et.EpisodiosTags)
                .HasForeignKey(e => e.TagId);


            builder.ToTable("EpisodioTag");
        }
    }
}
