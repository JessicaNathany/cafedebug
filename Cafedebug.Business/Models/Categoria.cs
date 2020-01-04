namespace Cafedebug.Business.Models
{
    /// <summary>
    /// entidade Categoria
    /// </summary>
    public class Categoria : Entity
    {
        /// <summary>
        /// Id do tipo da categoria
        /// </summary>
        public int IdTipoCategoria { get; set; }

        /// <summary>
        /// Nome da Categoria
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Descricao da Categoria
        /// </summary>
        public string Descricao { get; set; }
    }
}
