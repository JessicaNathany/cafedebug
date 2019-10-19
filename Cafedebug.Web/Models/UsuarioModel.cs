using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cafedebug.Web.Models
{
    /// <summary>
    /// classe de modelo do usuário para inclusão de DataAnottations
    /// </summary>
    public class UsuarioModel
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
        [Required(ErrorMessage="O login é um campo obrigatório", AllowEmptyStrings=false)]
        [RegularExpression(".+\\@.+\\..+!?''", ErrorMessage = "Não é permitido caracteres especiais")]
        public string Login { get; set; }

        /// <summary>
        /// Senha do usuário.
        /// </summary>
        [Required(ErrorMessage = "A senha é um campo obrigatório", AllowEmptyStrings = false)]
        [RegularExpression(".+\\@.+\\..+!?''", ErrorMessage = "Não é permitido caracteres especiais")]
        [Display(Name = "Informe a senha")]
        [StringLength(8, MinimumLength =6)]
        [DataType(DataType.Password)]
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
