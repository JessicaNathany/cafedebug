using System;

namespace Cafedebug.Business.Models
{
    /// <summary>
    /// entidade Email
    /// </summary>
    public class Email : Entity
    {
        /// <summary>
        /// Assunto do tbEmail
        /// </summary>
        public string Assunto { get; set; }

        /// <summary>
        /// remetente
        /// </summary>
        public string De { get; set; }

        /// <summary>
        /// Para email destino
        /// </summary>
        public string Para { get; set; }

        /// <summary>
        /// flag de envio
        /// </summary>
        public bool Enviado { get; set; }

        /// <summary>
        /// Template do email
        /// </summary>
        public string Template { get; set; }

        /// <summary>
        /// Data do envio do email
        /// </summary>
        public DateTime? DataEnvio { get; set; }
    }
}
