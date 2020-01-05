using System;

namespace Cafedebug.Business.Models
{
    /// <summary>
    /// Entidade Banner
    /// </summary>
    public class Banner
    {
        /// <summary>
        /// Id do Banner.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do Banner.
        /// </summary>
        public string Nome { get; set; }

        // relation
        public int ImagemId { get; set; }
        
        /// <summary>
        /// Imagem do Banner
        /// </summary>
        public Imagem Imagem { get; set; }

        /// <summary>
        /// Url do redirecionamento do Banner.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Data inicio do Banner
        /// </summary>
        public DateTime DataInicio { get; set; }

        /// <summary>
        /// Data fim do Banner.
        /// </summary>
        public DateTime DataFim { get; set; }

        /// <summary>
        /// Flag indica se o bater está ativo
        /// </summary>
        public bool Ativo { get; set; }

    }
}
