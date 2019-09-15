using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cafedebug.Model.Model;
using Cafedebug.Service;

namespace Cafedebug.Test.Service
{
    /// <summary>
    /// Test do serviço Usuário
    /// </summary>
    [TestClass]
    public class UsuarioServiceTest
    {
        /// <summary>
        /// Verifica o perfil do usuário antes de realizar 
        /// qualquer ação no sistema
        /// </summary>
        public void VerificaPersilUsuario()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
        }
    }
}
