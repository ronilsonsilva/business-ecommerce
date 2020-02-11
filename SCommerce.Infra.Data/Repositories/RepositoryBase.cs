using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Infra.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SCommerce.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ScContext Db = new ScContext();

        public void Add(TEntity entity)
        {
            Db.Set<TEntity>().Add(entity);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
            Db.Set<TEntity>().Remove(entity);
            Db.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            Db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
