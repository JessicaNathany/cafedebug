using Cafedebug.Business.Models;
using System;

namespace Cafedebug.Business.Interfaces
{
    public interface IEpisodeService : IDisposable
    {
        void Save(Episode episode);

        void Update(Episode episode);

        void Delete(int id);
    }
}
