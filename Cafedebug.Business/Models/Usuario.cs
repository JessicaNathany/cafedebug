using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cafedebug.Business
{
    /// <summary>
    /// entidade Usuario
    /// </summary>
    [Table("Usuario")]
    public class Usuario
    {
        /// <summary>
        /// Id do usuário.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Id do tbPerfil.
        /// </summary>
        public int IdPerfil { get; set; }

        /// <summary>
        /// Nome do usuário.
        /// </summary>
        [StringLength(50)]
        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// Email do usuário.
        /// </summary>
        [StringLength(100)]
        public string Email { get; set; }

        /// <summary>
        /// Login do usuário.
        /// </summary>
        [StringLength(10)]
        [Required]
        public string Login { get; set; }

        /// <summary>
        /// Senha do usuário.
        /// </summary>
        [StringLength(10)]
        [Required]
        public string Senha { get; set; }

        /// <summary>
        /// Flag indica se o usuário está ativo
        /// </summary>
        public bool FlagAtivo { get; set; }

        /// <summary>
        /// Imagem do usuário
        /// </summary>
        [StringLength(250)]
        public string UrlImagem { get; set; } 
    }
}
