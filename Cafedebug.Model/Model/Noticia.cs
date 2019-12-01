using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cafedebug.Model
{
    /// <summary>
    /// Entidade Noticia
    /// </summary>
    [Table("Noticia")]
    public class Noticia
    {
        /// <summary>
        /// Id do Noticia.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do Noticia.
        /// </summary>
        [StringLength(50)]
        public string Nome { get; set; }

        /// <summary>
        /// Titulo da Noticia.
        /// </summary>
        [StringLength(100)]
        public string Titulo { get; set; }

        /// <summary>
        /// Descricao da Noticia.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Url da imagem do Noticia
        /// </summary>
        [StringLength(250)]
        public string UrlImagem { get; set; }

        /// <summary>
        /// Link da Noticia.
        /// </summary>
        [StringLength(250)]
        public string LinkNoticia { get; set; }

        /// <summary>
        /// Data publicação da Noticia
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime DataPublicacao { get; set; }
    }
}
