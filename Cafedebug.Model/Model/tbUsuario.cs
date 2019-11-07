namespace Cafedebug.Model
{
    /// <summary>
    /// entidade tbUsuario
    /// </summary>
    public class tbUsuario
    {
        /// <summary>
        /// Id do usuário.
        /// </summary>
        public int IdUsuario { get; set; }

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
        /// Login do usuário.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Senha do usuário.
        /// </summary>
        public string Senha { get; set; }

        /// <summary>
        /// Flag indica se o usuário está ativo
        /// </summary>
        public bool FlagAtivo { get; set; }

        /// <summary>
        /// Imagem do usuário
        /// </summary>
        public string UrlImagem { get; set; } 
    }
}
