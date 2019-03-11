using System;
using System.Security.Cryptography;
using System.Text;

namespace Cafedebug.Configuration
{
    /// <summary>
    /// Classe para criptografia de senha
    /// </summary>
    public class Hash
    {
        private HashAlgorithm _algoritmo;

        public Hash(HashAlgorithm algoritmo)
        {
            _algoritmo = algoritmo;
        }

        /// <summary>
        /// Criptografar senha do usuário
        /// </summary>
        /// <param name="senha"></param>
        /// <returns></returns>
        public string CriptographyPassword(string senha)
        {
            var encodedValue = Encoding.UTF8.GetBytes(senha);
            var encryptedPassword = _algoritmo.ComputeHash(encodedValue);

            var sb = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                sb.Append(caracter.ToString("X2"));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Verifica senha do usuário
        /// </summary>
        /// <param name="senhaDigitada"></param>
        /// <param name="senhaCadastrada"></param>
        /// <returns></returns>
        public bool VerifyPassword(string senhaDigitada, string senhaCadastrada)
        {
            if (string.IsNullOrEmpty(senhaCadastrada))
                throw new NullReferenceException("Cadastre uma senha.");

            var encryptedPassword = _algoritmo.ComputeHash(Encoding.UTF8.GetBytes(senhaDigitada));

            var sb = new StringBuilder();
            foreach (var caractere in encryptedPassword)
            {
                sb.Append(caractere.ToString("X2"));
            }

            return sb.ToString() == senhaCadastrada;
        }
    }
}
