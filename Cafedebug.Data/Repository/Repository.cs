using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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

        public void Dispose()
        {
            Db?.Dispose();
        }
        
        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
           return DbSet.ToList(); 
           
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity Save(TEntity entity)
        {
            DbSet.Add(entity);
            SaveChanges();
            return entity;
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
              SaveChanges();
        }

        public void Delete(int id)
        {
            DbSet.Remove(new TEntity { Id = id });
            SaveChanges();
        }

        public int Count()
        {
            return DbSet.Count();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }
    }
}