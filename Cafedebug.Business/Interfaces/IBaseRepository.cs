using Cafedebug.Business.Models;
using System.Collections.Generic;

namespace Cafedebug.Business.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : Entity
    {
        TEntity Save(TEntity entity);

        void Update(int entity);

        void Delete(int entity);

        IList<TEntity> GetAll();

        TEntity GetById(int id);
    }
}
