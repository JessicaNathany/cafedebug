using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cafedebug.Business
{
    /// <summary>
    /// entidade Episodio 
    /// </summary>
    [Table("Episodio")]
    public class Episodio
    {
        /// <summary>
        /// Id da episódio.
        ///</summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome da episódio.
        /// </summary>
        [StringLength(50)]
        public string Nome { get; set; }

        /// <summary>
        /// Título da episódio.
        /// </summary>
        [StringLength(50)]
        public string Titulo { get; set; }

        /// <summary>
        /// Descrição da episódio.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Url link do episódio. (SoundCloud / Spotity)
        /// </summary>
        [StringLength(250)]
        public string Url { get; set; }

        /// <summary>
        /// Url da Imagem de capa do episódio.
        /// </summary>
        [StringLength(250)]
        public string UrlImagem { get; set; }

        /// <summary>
        /// Tag da episódio.
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// Data da episódio.
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime Data { get; set; }
    }
}
