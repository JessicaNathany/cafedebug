using System;

namespace Cafedebug.Business.Models
{
    /// <summary>
    /// Entidade Noticia
    /// </summary>
    public class Noticia : Entity
    {
        /// <summary>
        /// Titulo da Noticia.
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Descricao da Noticia.
        /// </summary>
        public string Descricao { get; set; }

        // relation
        public int ImagemId { get; set; }

        /// <summary>
        /// Imagem do Banner
        /// </summary>
        public Imagem Imagem { get; set; }

        /// <summary>
        /// Link da Noticia.
        /// </summary>
        public string LinkNoticia { get; set; }

        /// <summary>
        /// Data publicação da Noticia
        /// </summary>
        public DateTime DataPublicacao { get; set; }

        /// <summary>
        /// Data da atualização da noticia
        /// </summary>
        public DateTime DataAtualizacao { get; set; }
    }
}
