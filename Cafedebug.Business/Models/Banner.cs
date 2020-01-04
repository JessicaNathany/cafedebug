using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cafedebug.Business
{
    /// <summary>
    /// Entidade Banner
    /// </summary>
    [Table("Banner")]
    public class Banner
    {
        /// <summary>
        /// Id do Banner.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do Banner.
        /// </summary>
        [StringLength(50)]
        public string Nome { get; set; }

        /// <summary>
        /// Url Imagem do Banner
        /// </summary>
        [StringLength(250)]
        public string UrlImagem { get; set; }

        /// <summary>
        /// Url do redirecionamento do Banner.
        /// </summary>
        [StringLength(250)]
        public string Url { get; set; }

        /// <summary>
        /// Data inicio do Banner
        /// </summary>
        public DateTime DataInicio { get; set; }

        /// <summary>
        /// Data fim do Banner.
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime DataFim { get; set; }

        /// <summary>
        /// Flag indica se o bater está ativo
        /// </summary>
        public bool FlagAtivo { get; set; }
    }
}
