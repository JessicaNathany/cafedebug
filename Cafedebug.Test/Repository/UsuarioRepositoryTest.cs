using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cafedebug.Model;
using Cafedebug.Repository;

namespace Cafedebug.Test.Repository
{
    [TestClass]
    public class UsuarioRepositoryTest
    {
        /// <summary>
        /// Testa o método Save do Repository (para testar a funcionalidade do Dapper)
        /// </summary>
        [TestMethod]
        public void SaveTest()
        {
            var repo = new UsuarioRepository();
            var entity = new tbUsuario()
            {
                Nome = "Teste 1",
                Email = "teste@teste.com",
                Login = "Insert Test",
                Senha = "123456"
            };

            repo.Save(entity);
        }
    }
}
