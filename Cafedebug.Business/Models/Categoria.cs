using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cafedebug.Business
{
    /// <summary>
    /// entidade Categoria
    /// </summary>
    [Table("Categoria")]
    public class Categoria
    {
        /// <summary>
        /// Id da Categoria
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Id do tipo da categoria
        /// </summary>
        public int IdTipoCategoria { get; set; }

        /// <summary>
        /// Nome da Categoria
        /// </summary>
        [StringLength(50)]
        public string Nome { get; set; }

        /// <summary>
        /// Descricao da Categoria
        /// </summary>
        public string Descricao { get; set; }
    }
}
