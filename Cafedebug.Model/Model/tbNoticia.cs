using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafedebug.Model
{
    /// <summary>
    /// Entidade Noticia
    /// </summary>
    public class tbNoticia
    {
        /// <summary>
        /// Id do Noticia.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do Noticia.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Titulo da Noticia.
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Descricao da Noticia.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Imagem do Noticia
        /// </summary>
        public string Imagem { get; set; }  // mudar para tipo Bitmap

        /// <summary>
        /// Url do redirecionamento do Noticia.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Data da Noticia
        /// </summary>
        public DateTime Data { get; set; }
    }
}
