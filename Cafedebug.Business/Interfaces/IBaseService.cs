using System.Collections.Generic;

namespace Cafedebug.Business
{
    /// <summary>
    /// Interface base genérica
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseService<TEntity> where TEntity : class
    {
        void Save(TEntity obj);

        void Update(int id);

        void Delete(int id);

        IList<TEntity> GetAll();

        int GetById(int id);
    }
}
