namespace Cafedebug.Business.Models
{
    /// <summary>
    /// entidade Patrocinador
    /// </summary>
    public class Sponsor : Entity
    {
        public string Nome { get; set; }

        public string UrlTwitter { get; set; }

        public string UrlLinkedin { get; set; }

        // relation
        public int ImageId { get; set; }

        public Image Image { get; set; }

        public string Bio { get; set; }
    }
}
