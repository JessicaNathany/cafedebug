using System;
using System.Collections.Generic;
using System.Text;

namespace Cafedebug.Model.DTO
{
    /// <summary>
    /// Classe Usuario de transferência de dados 
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
        /// Flag lembrar senha
        /// </summary>
        public bool LembrarSenha { get; set; }

        /// <summary>
        /// Mensagem do login.
        /// </summary>
        public string Mensagem { get; set; }
    }
}

