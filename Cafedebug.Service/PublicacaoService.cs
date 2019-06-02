using System;
using System.Collections.Generic;
using Cafedebug.Model;
using Cafedebug.Service.Interface;
using log4net;
using Cafedebug.Repository.Interface;
using Unity;

namespace Cafedebug.Service
{
    /// <summary>
    /// Serviço da Publicação
    /// </summary>
    public class PublicacaoService : IPublicacaoService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(PublicacaoService));

        /// <summary>
        /// Repositório Publicação
        /// </summary>
        [Dependency]
        public Lazy<IPublicacaoRepository> PublicacaoRepository { get; set; }

        /// <summary>
        /// Repositório do Usuário
        /// </summary>
        [Dependency]
        public Lazy<IUsuarioRepository> UsuarioRepository { get; set; }

        /// <summary>
        /// Insere uma nova publicação
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public void Save(Publicacao publicacao)
        {
            try
            {
                PublicacaoRepository.Value.Save(publicacao);
            }
            catch (Exception ex)
            {
                Log.ErrorFormat("Erro ao salvar um usuário", ex.Message, publicacao);
                throw;
            }
        }

        /// <summary>
        /// Atualiza uma publicação
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public void Update(int id)
        {
            try
            {
                PublicacaoRepository.Value.Update(id);
            }
            catch (Exception ex)
            {
                Log.ErrorFormat("Erro ao atualizar um usuário", ex.Message, id);
                throw;
            }
        }

        /// <summary>
        /// Exclui uma publicação
        /// </summary>
        /// <param name="obj"></param>
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Recupera uma lista de publicações
        /// </summary>
        /// <returns></returns>
        public IList<Publicacao> GetAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Recupera uma publicação por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
