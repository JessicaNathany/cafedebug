using System.Collections.Generic;
using Cafedebug.Model;
using Cafedebug.Repository.Interface;
using System;
using log4net;
using System.Data.SqlClient;
using System.Configuration;
using Cafedebug.Configuration;
using Dapper;
using System.Threading.Tasks;

namespace Cafedebug.Repository
{
    /// <summary>
    /// Repositório do tbUsuario
    /// </summary>
    public class UsuarioRepository : IUsuarioRepository
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(UsuarioRepository));

        static string connectionString = ConfigurationManager.ConnectionStrings["CafedeBugConnectionString"].ConnectionString;

        /// <summary>
        /// Salva um usuário na base
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public void Save(Usuario entity)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Execute(@"INSERT tbUsuario(Nome, Email, Login, Senha)
                                            VALUES (@Nome, @Email, @Login, @Senha)", entity);

                    Log.InfoFormat("Usuário cadastrado com sucesso! {0}", entity);
                }
            }
            catch (Exception ex)
            {
                Log.ErrorFormat("Erro ao cadastrar um usuário! {0}", ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Atualiza um usuário na base
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public void Update(Usuario entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Exclui um usuário na base
        /// </summary>
        /// <param name="obj"></param>
        public void Delete(Usuario entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Recupera uma lista de usuários na base
        /// </summary>
        /// <returns></returns>
        public IList<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Recupera um usuário através do Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetById(int id)
        {
            throw new NotImplementedException();

            //try
            //{
            //    using (var connection = new SqlConnection(connectionString))
            //    {
            //        var produtos = connection.Query<Usuario>(@"SELECT * FROM Products WHERE ProductID = @Id", new { id = 2 });
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        /// <summary>
        /// Verifica a senha do usuário ao fazer o login
        /// </summary>
        /// <returns></returns>
        public bool VerifyUserPassword(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Login) || string.IsNullOrEmpty(usuario.Senha))
            {
                throw new ArgumentNullException();
            }

            throw new NotImplementedException();
        }
    }
}
