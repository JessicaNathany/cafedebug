using System;

namespace Cafedebug.Business.Models
{
    /// <summary>
    /// Entidade Noticia
    /// </summary>
    public class Noticia : Entity
    {
        /// <summary>
        /// Nome do Noticia.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Titulo da Noticia.
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Descricao da Noticia.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Url da imagem do Noticia
        /// </summary>
        public string UrlImagem { get; set; }

        /// <summary>
        /// Link da Noticia.
        /// </summary>
        public string LinkNoticia { get; set; }

        /// <summary>
        /// Data publicação da Noticia
        /// </summary>
        public DateTime DataPublicacao { get; set; }
    }
}
