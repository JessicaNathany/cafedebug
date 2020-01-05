namespace Cafedebug.Business.Models
{
    /// <summary>
    /// entidade Usuario
    /// </summary>
    public class Usuario : Entity
    {
        /// <summary>
        /// Nome do usuário.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Email do usuário.
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Senha do usuário.
        /// </summary>
        public string Senha { get; set; }

        /// <summary>
        /// Flag indica se o usuário está ativo
        /// </summary>
        public bool Ativo { get; set; }

        // relation
        public int ImagemId { get; set; }

        /// <summary>
        /// Imagem do Banner
        /// </summary>
        public Imagem Imagem { get; set; }
    }
}
