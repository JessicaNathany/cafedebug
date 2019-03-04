using System;

namespace Cafedebug.Configuration
{
    /// <summary>
    /// Exception que ocorre sempre que ocorrer algum problema com o acesso a dados.
    /// </summary>
    public class DataAccessException : ApplicationException
    {
        /// <summary>
        /// Cria uma nova instância da classe DataAccessException.
        /// </summary>
        /// <param name="message">Mensagem de erro.</param>
        public DataAccessException(string message) : this(message, null) { }

        /// <summary>
        /// Cria uma nova instância da classe DataAccessException.
        /// </summary>
        /// <param name="message">Mensagem de erro.</param>
        /// <param name="innerException">Exception original.</param>
        public DataAccessException(string message, Exception innerException) : base(message, innerException) { }
    }
}
