using Cafedebug.Business.Models;
using System;

namespace Cafedebug.Business.Interfaces
{
    public interface ICategoryService : IDisposable
    {
        void Save(Category category);

        void Update(Category category);

        void Remove(int id);
    }
}
