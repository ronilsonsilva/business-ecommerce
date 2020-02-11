using SCommerce.Domain.Interfaces.Repositories;
using SCommerce.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(Guid ID)
        {
            return _repository.GetById(ID);
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
    }
}
