using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cafedebug.Business
{
    /// <summary>
    /// entidade Email
    /// </summary>
    [Table("Email")]
    public class Email
    {
        /// <summary>
        /// Id do email
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Assunto do tbEmail
        /// </summary>
        [StringLength(50)]
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
        [DataType(DataType.DateTime)]
        public DateTime? DataEnvio { get; set; }
    }
}
