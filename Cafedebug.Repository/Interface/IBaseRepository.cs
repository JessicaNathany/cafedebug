using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafedebug.Repository.Interface
{
    /// <summary>
    /// Repositório base
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Save(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        IList<TEntity> GetAll();

        int GetById(int id);
    }
}
