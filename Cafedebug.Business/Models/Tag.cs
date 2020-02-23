using System.Collections.Generic;

namespace Cafedebug.Business.Models
{
    public class Tag : Entity
    {
        public string Name { get; set; }

        public IList<EpisodeTag> EpisodesTags { get; set; }
    }
}
