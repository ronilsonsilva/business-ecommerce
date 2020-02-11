using SCommerce.Application.Interfaces;
using SCommerce.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Application.Services
{
    public class AppServiceBase<TEntity> : IDisposable, IServiceBaseApp<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity entity)
        {
            _serviceBase.Add(entity);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity GetById(Guid id)
        {
            return _serviceBase.GetById(id);
        }

        public void Remove(TEntity entity)
        {
            _serviceBase.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _serviceBase.Update(entity);
        }
    }
}
