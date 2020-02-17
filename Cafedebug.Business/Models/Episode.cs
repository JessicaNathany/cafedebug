using System;
using System.Collections.Generic;

namespace Cafedebug.Business.Models
{
    public class Episode : Entity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Url link do episódio. (SoundCloud / Spotity)
        /// </summary>
        public string Url { get; set; }

        public int ImageId { get; set; }

        public Image Image { get; set; }

        public IList<EpisodeTag> EpisodiesTags { get; set; }

        public DateTime PublicationDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public bool Ative { get; set; }
    }
}
