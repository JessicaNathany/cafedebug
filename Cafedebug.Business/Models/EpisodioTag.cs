namespace Cafedebug.Business.Models
{
    public class EpisodioTag
    {
        public int Id { get; set; }

        public int EpisodioId { get; set; }

        public Episodio Episodio { get; set; }

        public int TagId { get; set; }

        public Tag Tag { get; set; }
    }
}
