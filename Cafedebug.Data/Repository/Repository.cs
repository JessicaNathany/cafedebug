using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Cafedebug.Data.Repository
{
    public abstract class Repository<TEntity> : IBaseRepository<TEntity> where TEntity : Entity, new()
    {

        protected readonly CafedebugContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(CafedebugContext db)
        {
            Db = db;
            DbSet = Db.Set<TEntity>();
        }

        public void Delete(int entity)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public int GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int entity)
        {
            throw new NotImplementedException();
        }
    }
}
