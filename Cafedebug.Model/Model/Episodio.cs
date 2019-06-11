using System;

namespace Cafedebug.Model
{
    /// <summary>
    /// entidade tbEpisodio 
    /// </summary>
    public class Episodio
    {
        /// <summary>
        /// Id da episódio.
        /// </summary>
        public int IdEpisodio { get; set; }

        /// <summary>
        /// Nome da episódio.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Título da episódio.
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Descrição da episódio.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Url da episódio.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Image da episódio.
        /// </summary>
        public string Image { get; set; } // verificar propriedade

        /// <summary>
        /// Tag da episódio.
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Data da episódio.
        /// </summary>
        public DateTime Data { get; set; }
    }
}
