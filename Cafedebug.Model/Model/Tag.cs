using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cafedebug.Model.Model
{
    /// <summary>
    /// Entidade Tag
    /// </summary>
    [Table("Tag")]
    public class Tag
    {
        /// <summary>
        /// Id da Tag.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Descrição da Tag
        /// </summary>
        [StringLength(50)]
        public string Descricao { get; set; }
    }
}
