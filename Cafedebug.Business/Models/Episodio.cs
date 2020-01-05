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

        /// <summary>
        /// Url da Imagem de capa do episódio.
        /// </summary>
        public string UrlImagem { get; set; }

        /// <summary>
        /// Tags do episódio.
        /// </summary>
        public IList<EpisodioTag> EpisodiosTags { get; set; }

        /// <summary>
        /// Data da episódio.
        /// </summary>
        public DateTime Data { get; set; }

        /// <summary>
        /// Indica se o episodio está ativo
        /// </summary>
        public bool Ativo { get; set; }
    }
}
