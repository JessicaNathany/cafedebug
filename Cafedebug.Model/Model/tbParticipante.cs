namespace Cafedebug.Model
{
    /// <summary>
    /// Entidade tbParticipante
    /// </summary>
    public class tbParticipante
    {
        /// <summary>
        /// Id do participante
        /// </summary>
        public int idParticipante { get; set; }

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
    }
}
