using System.Collections.Generic;
using Cafedebug.Model;
using Cafedebug.Repository.Interface;

namespace Cafedebug.Repository
{
    /// <summary>
    /// Repositório do tbPublicação
    /// </summary>
    public class PublicacaoRepository : IPublicacaoRepository
    {
        /// <summary>
        /// Salva uma publicação
        /// </summary>
        /// <param name="entity"></param>
        public void Save(Publicacao entity)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Atualiza uma publicação
        /// </summary>
        /// <param name="entity"></param>
        public void Update(int entity)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Exclui uma publicação
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(int entity)
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
        /// Recupera uma publicação pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
