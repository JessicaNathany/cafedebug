using System;

namespace Cafedebug.Model
{
    /// <summary>
    /// Entidade Banner
    /// </summary>
    public class tbBanner
    {
        /// <summary>
        /// Id do Banner.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do Banner.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Imagem do Banner
        /// </summary>
        public string Imagem { get; set; }  // mudar para tipo Bitmap

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
        public bool FlagAtivo { get; set; }
    }
}
