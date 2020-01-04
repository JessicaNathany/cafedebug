using System.Collections.Generic;

namespace Cafedebug.Business
{
    /// <summary>
    /// Repositório base
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Save(TEntity entity);

        void Update(int entity);

        void Delete(int entity);

        IList<TEntity> GetAll();

        int GetById(int id);
    }
}
