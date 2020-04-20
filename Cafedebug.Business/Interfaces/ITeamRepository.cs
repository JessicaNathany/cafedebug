using Cafedebug.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafedebug.Business.Interfaces
{
    public interface ITeamRepository : IBaseRepository<Team>
    {
         PageResult<Team> GetPaged(PageRequest page);
    }
}
