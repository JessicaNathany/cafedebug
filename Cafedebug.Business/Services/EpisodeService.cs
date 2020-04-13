using System;
using System.Collections.Generic;
using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Business.Models.Validations;
using log4net;

namespace Cafedebug.Business.Services
{
    public class EpisodeService : BaseService, IEpisodeService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(EpisodeService));

        private readonly IEpisodeRepository _episodeRepository;

        public EpisodeService(INotifier notifier, IEpisodeRepository episodeRepository) : base(notifier)
        {
            _episodeRepository = episodeRepository;
        }

        public void Save(Episode episode)
        {
            try
            {
                if (!ExecuteValidation(new EpisodeValidation(), episode)) return;

                _episodeRepository.Save(episode);
            }
            catch (Exception ex)
            {
                Notify("Erro ao salvar o episódio");
                Log.ErrorFormat("Erro ao salvar um episódio", ex.Message, episode);
                throw;
            }
        }

        public void Update(Episode episode)
        {
            try
            {
                if (!ExecuteValidation(new EpisodeValidation(), episode)) return;

                _episodeRepository.Update(episode);
            }
            catch (Exception ex)
            {
                Notify("Erro ao atualizar o episódio");
                Log.ErrorFormat("Erro ao atualizar um episódio", ex.Message, episode);
                throw;
            }
        }

        public void Delete(int id)
        {
            _episodeRepository.Delete(id);
        }

        public IList<Episode> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _episodeRepository?.Dispose();
        }
    }
}