using Cafedebug.Business.Models;

namespace Cafedebug.Business.Services
{
    public interface ITeamService 
    {
        void Save(Team team);
        void Update(Team team);
        void DeleteById(int id);
        void Dispose();
    }
}