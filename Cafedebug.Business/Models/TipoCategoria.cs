using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cafedebug.Business
{
    /// <summary>
    /// Entidade TipoCategoria
    /// </summary>
    [Table("TipoCategoria")]
    public class TipoCategoria
    {
        /// <summary>
        /// Id do tipo da categoria
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// nome do tipo da categoria
        /// </summary>
        [StringLength(100)]
        public int Nome { get; set; }
    }
}
