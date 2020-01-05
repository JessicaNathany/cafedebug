using System;
using System.Collections.Generic;

namespace Cafedebug.Business.Models
{
    /// <summary>
    /// entidade Episodio 
    /// </summary>
    public class Episodio : Entity
    {
        /// <summary>
        /// Título da episódio.
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Descrição da episódio.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Url link do episódio. (SoundCloud / Spotity)
        /// </summary>
        public string Url { get; set; }

        // relation
        public int ImagemId { get; set; }

        /// <summary>
        /// Imagem do Banner
        /// </summary>
        public Imagem Imagem { get; set; }

        /// <summary>
        /// Tags do episódio.
        /// </summary>
        public IList<EpisodioTag> EpisodiosTags { get; set; }

        /// <summary>
        /// Data da publicação do episódio.
        /// </summary>
        public DateTime DataPublicacao { get; set; }

        /// <summary>
        /// Data da atualização do episódio.
        /// </summary>
        public DateTime DataAtualizacao { get; set; }

        /// <summary>
        /// Indica se o episodio está ativo
        /// </summary>
        public bool Ativo { get; set; }
    }
}
