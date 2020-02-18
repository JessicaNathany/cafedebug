using System;

namespace Cafedebug.Business.Models
{
    public class Banner
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int ImagemId { get; set; }
        
        public Image Imagem { get; set; }

        public string Url { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public bool Ativo { get; set; }
    }
}
