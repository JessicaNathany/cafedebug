using System;
using System.Collections.Generic;
using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using log4net;

namespace Cafedebug.Business.Services
{
    /// <summary>
    /// Serviço da Episódio
    /// </summary>
    public class EpisodioService : BaseService, IEpisodioService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(EpisodioService));

        /// <summary>
        /// Repositório Episódio
        /// </summary>
        public Lazy<IEpisodioRepository> EpisodioRepository { get; set; }

        /// <summary>
        /// Repositório do Usuário
        /// </summary>
        public Lazy<IUsuarioRepository> UsuarioRepository { get; set; }

        public EpisodioService(INotificador notificador) : base(notificador)
        {

        }


        /// <summary>
        /// Insere uma nova Episódio
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public void Save(Episodio episodio)
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
        public IList<Episodio> GetAll()
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
        public Usuario ExcluiUsuarioExistenteNaBase(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
