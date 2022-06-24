using acme.sistemas.compracoletiva.core.Interfaces;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public void Add(TEntity entity) => _baseRepository.Add(entity);

        public Task AddAsync(TEntity entity) => _baseRepository.AddAsync(entity);

        public void AddMultiple(IEnumerable<TEntity> entities) => _baseRepository.AddMultiple(entities);

        public Task AddMultipleAsync(IEnumerable<TEntity> entities)=> _baseRepository.AddMultipleAsync(entities);

        public IQueryable<TEntity> GetAll() => _baseRepository.GetAll();

        public Task<IQueryable<TEntity>> GetAllAsync() => _baseRepository.GetAllAsync();

        public TEntity GetById(Guid id) => _baseRepository.GetById(id);

        public Task<TEntity> GetByIdAsync(Guid id) => _baseRepository.GetByIdAsync(id);

        public List<TEntity> GetList() => _baseRepository.GetList();


        public Task<List<TEntity>> GetListAsync() => _baseRepository.GetListAsync();

        public void Remove(TEntity entity) => _baseRepository.Remove(entity);

        public void RemoveMultiple(IEnumerable<TEntity> entities) => _baseRepository.RemoveMultiple(entities);

        public void Update(TEntity entity) => _baseRepository.Update(entity);

        public void UpdateMultiple(IEnumerable<TEntity> entities) => _baseRepository.UpdateMultiple(entities);
    }
}
