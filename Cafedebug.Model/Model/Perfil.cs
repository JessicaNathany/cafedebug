namespace cafedebug.web.Models
{
    /// <summary>
    /// entidade tbPerfil
    /// </summary>
    public class Perfil
    {
        /// <summary>
        /// Id do perfil.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id do Usuario.
        /// </summary>
        public int IdUsuario { get; set; }

        /// <summary>
        /// Nome do perfil.
        /// </summary>
        public string Nome { get; set; }
    }
}