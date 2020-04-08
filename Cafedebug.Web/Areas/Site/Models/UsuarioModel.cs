using System.ComponentModel.DataAnnotations;

namespace Cafedebug.Web.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        [Required(ErrorMessage="O login é um campo obrigatório", AllowEmptyStrings=false)]
        [RegularExpression(".+\\@.+\\..+!?''", ErrorMessage = "Não é permitido caracteres especiais")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A senha é um campo obrigatório", AllowEmptyStrings = false)]
        [RegularExpression(".+\\@.+\\..+!?''", ErrorMessage = "Não é permitido caracteres especiais")]
        [Display(Name = "Informe a senha")]
        [StringLength(8, MinimumLength =6)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public bool LembrarSenha { get; set; }

        public string Mensagem { get; set; }
    }
}
