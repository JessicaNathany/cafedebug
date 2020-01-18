using System;
using System.Collections.Generic;

namespace Cafedebug.Business.Models
{
    public class Episodio : Entity
    {
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        /// <summary>
        /// Url link do episódio. (SoundCloud / Spotity)
        /// </summary>
        public string Url { get; set; }

        public int ImagemId { get; set; }

        public Imagem Imagem { get; set; }

        public IList<EpisodioTag> EpisodiosTags { get; set; }

        public DateTime DataPublicacao { get; set; }

        public DateTime DataAtualizacao { get; set; }

        public bool Ativo { get; set; }
    }
}
