namespace Cafedebug.Business.Models
{
    public class EpisodeTag
    {
        public int Id { get; set; }

        public int EpisodioId { get; set; }

        public Episode Episodio { get; set; }

        public int TagId { get; set; }

        public Tag Tag { get; set; }
    }
}
