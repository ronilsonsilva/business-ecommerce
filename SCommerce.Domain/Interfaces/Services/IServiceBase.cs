using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        TEntity GetById(Guid ID);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void Dispose();
    }
}
