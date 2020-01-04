using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cafedebug.Business
{
    /// <summary>
    /// Entidade Participante
    /// </summary>
    [Table("Participante")]
    public class Participante
    {
        /// <summary>
        /// Id do participante
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do participante
        /// </summary>
        [StringLength(50)]
        public string Nome { get; set; }

        /// <summary>
        /// Url do twitter
        /// </summary>
        [StringLength(250)]
        public string UrlTwitter { get; set; }

        /// <summary>
        /// Url do Linkedin
        /// </summary>
        [StringLength(250)]
        public string UrlLinkedin { get; set; }

        /// <summary>
        /// Url da imagem do participante
        /// </summary>
        [StringLength(250)]
        public string UrlImagem { get; set; }

        /// <summary>
        /// Mini Bio do participante
        /// </summary>
        [StringLength(250)]
        public string Bio { get; set; }
    }
}
