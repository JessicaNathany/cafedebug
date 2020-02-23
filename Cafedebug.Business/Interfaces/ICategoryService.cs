using Cafedebug.Business.Models;
using System;

namespace Cafedebug.Business.Interfaces
{
    public interface ICategoryService : IDisposable
    {
        Category Save(Category category);

        Category Update(Category category);

        Category Remove(int id);
    }
}
