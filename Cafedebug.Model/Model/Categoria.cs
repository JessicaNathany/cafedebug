namespace Cafedebug.Model
{
    /// <summary>
    /// entidade tbCategoria
    /// </summary>
    public class Categoria
    {
        /// <summary>
        /// Id da Categoria
        /// </summary>
        public int IdCategoria { get; set; }

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
