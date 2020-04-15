using Cafedebug.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafedebug.Business.Services
{
    public class TeamService : BaseService, ITeamService
    {
        public TeamService(INotifier notifier) : base(notifier)
        {
        }
    }
}
