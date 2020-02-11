using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Interfaces
{
    public interface IServiceBaseApp<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void Dispose();
    }
}
