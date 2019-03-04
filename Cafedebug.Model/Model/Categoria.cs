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
        public int Id { get; set; }

        /// <summary>
        /// Id da Publicação
        /// </summary>
        public int IdPublicacao { get; set; }

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
