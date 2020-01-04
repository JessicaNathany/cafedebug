using Cafedebug.Business.Models;
using System.Collections.Generic;

namespace Cafedebug.Business.Interfaces
{
    /// <summary>
    /// Repositório base
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseRepository<TEntity> where TEntity : Entity
    {
        void Save(TEntity entity);

        void Update(int entity);

        void Delete(int entity);

        IList<TEntity> GetAll();

        int GetById(int id);
    }
}
