using System.Collections.Generic;
using Cafedebug.Model;
using Cafedebug.Service.Interface;

namespace Cafedebug.Service
{
    /// <summary>
    /// Serviço da Publicação
    /// </summary>
    public class PublicacaoService : IPublicacaoService
    {
        /// <summary>
        /// Insere uma nova publicação
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Save(Publicacao obj)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Atualiza uma publicação
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Update(Publicacao obj)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Exclui uma publicação
        /// </summary>
        /// <param name="obj"></param>
        public void Delete(Publicacao obj)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Recupera uma lista de publicações
        /// </summary>
        /// <returns></returns>
        public IList<Publicacao> GetAll()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Recupera uma publicação por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetById(int id)
        {
            throw new System.NotImplementedException();
        }

       
    }
}
