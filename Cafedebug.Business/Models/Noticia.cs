using System;

namespace Cafedebug.Business.Models
{
    public class Noticia : Entity
    {
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        // relation
        public int ImagemId { get; set; }

        public Imagem Imagem { get; set; }

        public string LinkNoticia { get; set; }

        public DateTime DataPublicacao { get; set; }

        public DateTime DataAtualizacao { get; set; }
    }
}
