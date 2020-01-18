namespace Cafedebug.Business.Models
{
    public class Participante : Entity
    {
        public string Nome { get; set; }

        public string UrlTwitter { get; set; }

        public string UrlLinkedin { get; set; }

        // relation
        public int ImagemId { get; set; }

        public Imagem Imagem { get; set; }

        public string Bio { get; set; }
    }
}
