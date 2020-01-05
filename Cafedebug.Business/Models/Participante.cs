namespace Cafedebug.Business.Models
{
    /// <summary>
    /// Entidade Participante
    /// </summary>
    public class Participante : Entity
    {
        /// <summary>
        /// Nome do participante
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Url do twitter
        /// </summary>
        public string UrlTwitter { get; set; }

        /// <summary>
        /// Url do Linkedin
        /// </summary>
        public string UrlLinkedin { get; set; }

        // relation
        public int ImagemId { get; set; }

        /// <summary>
        /// Imagem do Banner
        /// </summary>
        public Imagem Imagem { get; set; }

        /// <summary>
        /// Mini Bio do participante
        /// </summary>
        public string Bio { get; set; }
    }
}
