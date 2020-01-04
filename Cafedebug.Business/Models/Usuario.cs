namespace Cafedebug.Business.Models
{
    /// <summary>
    /// entidade Usuario
    /// </summary>
    public class Usuario : Entity
    {

        /// <summary>
        /// Id do tbPerfil.
        /// </summary>
        public int IdPerfil { get; set; }

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

        /// <summary>
        /// Imagem do usuário
        /// </summary>
        public string UrlImagem { get; set; } 
    }
}
