using System.Collections.Generic;

namespace Cafedebug.Business.Models
{
    public class Tag : Entity
    {
        public string Nome { get; set; }

        public IList<EpisodeTag> EpisodiosTags { get; set; }
    }
}
