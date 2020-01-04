using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cafedebug.Business
{
    /// <summary>
    /// entidade Perfil
    /// </summary>
    [Table("Perfil")]
    public class Perfil
    {
        /// <summary>
        /// Id do perfil.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do perfil.
        /// </summary>
        [StringLength(50)]
        public string Nome { get; set; }
    }
}