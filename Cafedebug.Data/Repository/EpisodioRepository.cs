using System.Collections.Generic;
using Cafedebug.Business;
using log4net;

namespace Cafedebug.Data
{
    /// <summary>
    /// Repositório do tbPublicação
    /// </summary>
    public class EpisodioRepository : IEpisodioRepository
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(UsuarioRepository));

        private readonly CafedebugContext _contexto;

        /// <summary>
        /// Salva uma publicação
        /// </summary>
        /// <param name="entity"></param>
        public void Save(Episodio entity)
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
        public IList<Episodio> GetAll()
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
