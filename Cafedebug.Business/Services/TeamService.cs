using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Business.Models.Validations;
using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafedebug.Business.Services
{
    public class TeamService : BaseService, ITeamService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(TeamService));
        private readonly ITeamRepository _teamRepository;
        public TeamService(INotifier notifier, ITeamRepository teamRepository) : base(notifier)
        {
            _teamRepository = teamRepository;
        }

        public void Save(Team team)
        {
            try
            {
                if (!ExecuteValidation(new TeamValidation(), team)) return;

                _teamRepository.Save(team);
            }
            catch (Exception ex)
            {
                Notify("Erro ao cadastrar colaborador.");
                Log.ErrorFormat("Erro ao cadastrar colaborador", ex.Message, team);
                throw;
            }
            
        }

        public void Update(Team team)
        {
            try
            {
                if (!ExecuteValidation(new TeamValidation(), team)) return;

                _teamRepository.Update(team);
            }
            catch (Exception ex)
            {
                Notify("Erro ao atualizar colaborador.");
                Log.ErrorFormat("Erro ao atualizar colaborador", ex.Message, team);
                throw;
            }
        }

         public void DeleteById(int id)
        {
            _teamRepository.Delete(id);
        }
        public void Dispose()
        {
            _teamRepository?.Dispose();
        }
    }
}
