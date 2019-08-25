using System;

namespace Cafedebug.Model
{
    /// <summary>
    /// entidade tbEmail
    /// </summary>
    public class tbEmail
    {
        /// <summary>
        /// Id do email
        /// </summary>
        public int IdEmail { get; set; }

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
