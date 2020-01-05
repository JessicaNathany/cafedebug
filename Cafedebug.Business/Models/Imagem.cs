namespace Cafedebug.Business.Models
{
    /// <summary>
    /// Entidade da imagem (todas as imagens do site)
    /// </summary>
    public class Imagem : Entity
    {
        /// <summary>
        /// Url da imagem
        /// </summary>
        public string UrlImagem { get; set; }

        /// <summary>
        /// Tipo da imagem (jpeg, png, etc)
        /// </summary>
        public string Tipo { get; set; }
    }
}
