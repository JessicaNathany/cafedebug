using System;
using System.Collections.Generic;
using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using FluentValidation;
using log4net;

namespace Cafedebug.Business.Services
{
    public class EpisodeService : BaseService, IEpisodeService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(EpisodeService));

        public Lazy<IEpisodeRepository> EpisodioRepository { get; set; }

        public EpisodeService(INotifier notifier) : base(notifier)
        {

        }

        public void Save(Episode episodio)
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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Episode> GetAll()
        {
            throw new NotImplementedException();
        }

        public int GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
