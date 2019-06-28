namespace Cafedebug.Model.DTO
{
    /// <summary>
    /// Classe Usuario de transferência de dados da View
    /// </summary>
    public class UsuarioDTO
    {
        /// <summary>
        /// Id do usuário.
        /// </summary>
        public int Id { get; set; }

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
        /// Mensagem.
        /// </summary>
        public string Mensagem { get; set; }
    }
}
