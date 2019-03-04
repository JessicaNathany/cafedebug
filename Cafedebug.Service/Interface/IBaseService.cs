using System.Collections.Generic;

namespace Cafedebug.Service.Interface
{
    /// <summary>
    /// Interface base genérica
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseService<TEntity> where TEntity : class
    {
        int Save(TEntity obj);

        bool Update(TEntity obj);

        void Delete(TEntity obj);

        IList<TEntity> GetAll();

        int GetById(int id);
    }
}
