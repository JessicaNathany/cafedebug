using System;
using System.Collections.Generic;
using Cafedebug.Model;
using Cafedebug.Service.Interface;
using log4net;
using Cafedebug.Repository.Interface;
using Unity;
using Cafedebug.Model.DTO;

namespace Cafedebug.Service
{
    /// <summary>
    /// Serviço da Episódio
    /// </summary>
    public class EpisodioService : IEpisodioService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(EpisodioService));

        /// <summary>
        /// Repositório Episódio
        /// </summary>
        [Dependency]
        public Lazy<IEpisodioRepository> EpisodioRepository { get; set; }

        /// <summary>
        /// Repositório do Usuário
        /// </summary>
        [Dependency]
        public Lazy<IUsuarioRepository> UsuarioRepository { get; set; }

        /// <summary>
        /// Insere uma nova Episódio
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public void Save(tbEpisodio episodio)
        {
            try
            {
                EpisodioRepository.Value.Save(episodio);
            }
            catch (Exception ex)
            {
                Log.ErrorFormat("Erro ao salvar um episódio", ex.Message, episodio);
                throw;
            }
        }

        /// <summary>
        /// Atualiza uma Episódio
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public void Update(int id)
        {
            try
            {
                EpisodioRepository.Value.Update(id);
            }
            catch (Exception ex)
            {
                Log.ErrorFormat("Erro ao atualizar um episódio", ex.Message, id);
                throw;
            }
        }

        /// <summary>
        /// Exclui uma Episódio
        /// </summary>
        /// <param name="obj"></param>
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Recupera uma lista de episódios
        /// </summary>
        /// <returns></returns>
        public IList<tbEpisodio> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Recupera uma Episódio por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetById(int id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        ///Exclui um usuário  existente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UsuarioDTO ExcluiUsuarioExistenteNaBase(int id)
        {
            throw new NotImplementedException();
        }
    }
}
