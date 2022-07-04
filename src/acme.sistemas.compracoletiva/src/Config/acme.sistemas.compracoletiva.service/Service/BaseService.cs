﻿using acme.sistemas.compracoletiva.core.Interfaces.Service;
using acme.sistemas.compracoletiva.domain.Entity;
using acme.sistemas.compracoletiva.domain.Interfaces.Aggregate;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository;
using AutoMapper;

namespace acme.sistemas.compracoletiva.service.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : IAggregateRoot
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public void Add(TEntity entity) => _baseRepository.Add(entity);

        public Task AddAsync(TEntity entity) => _baseRepository.AddAsync(entity);

        public void AddMultiple(IEnumerable<TEntity> entities) => _baseRepository.AddMultiple(entities);

        public Task AddMultipleAsync(IEnumerable<TEntity> entities) => _baseRepository.AddMultipleAsync(entities);

        public IQueryable<Entity> GetAll<TEntityRecover, Entity>() where TEntityRecover : class where Entity : BaseEntity => _baseRepository.GetAll<Entity>();

        public async Task<IQueryable<Entity>> GetAllAsync<TEntityRecover, Entity>() where TEntityRecover : class where Entity : BaseEntity => (await _baseRepository.GetAllAsync<Entity>());

        public Entity GetById<TEntityRecover, Entity>(Guid id) where TEntityRecover : class where Entity : BaseEntity => (_baseRepository.GetById<Entity>(id));

        public async Task<Entity> GetByIdAsync<TEntityRecover, Entity>(Guid id) where TEntityRecover : class where Entity : BaseEntity => (await _baseRepository.GetByIdAsync<Entity>(id));

        public List<Entity> GetList<TEntityRecover, Entity>() where TEntityRecover : class where Entity : BaseEntity => _baseRepository.GetList<Entity>();


        public async Task<List<Entity>> GetListAsync<TEntityRecover, Entity>() where TEntityRecover : class where Entity : BaseEntity => await _baseRepository.GetListAsync<Entity>();

        public void Remove(TEntity entity) => _baseRepository.Remove(entity);

        public void RemoveMultiple(IEnumerable<TEntity> entities) => _baseRepository.RemoveMultiple(entities);

        public void Update(TEntity entity) => _baseRepository.Update(entity);

        public void UpdateMultiple(IEnumerable<TEntity> entities) => _baseRepository.UpdateMultiple(entities);
    }
}
