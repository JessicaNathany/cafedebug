using System;

namespace Cafedebug.Model
{
    /// <summary>
    /// entidade tbPublicacao
    /// </summary>
    public class Publicacao
    {
        /// <summary>
        /// Id da publicação.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome da publicação.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Título da publicação.
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Descrição da publicação.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Url da publicação.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Image da publicação.
        /// </summary>
        public string Image { get; set; } // verificar propriedade

        /// <summary>
        /// Tag da publicação.
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Data da publicação.
        /// </summary>
        public DateTime Data { get; set; }
    }
}
