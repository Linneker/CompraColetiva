using acme.sistemas.compracoletiva.core.Interfaces;
using acme.sistemas.compracoletiva.core.Interfaces.Service;
using acme.sistemas.compracoletiva.domain.Entity;
using acme.sistemas.compracoletiva.domain.Interfaces.Aggregate;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.service.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : IAggregateRoot
    {
        private readonly IBaseRepository<TEntity> _baseRepository;
        private readonly IMapper _mapper;

        public BaseService(IBaseRepository<TEntity> baseRepository,
            IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public void Add(TEntity entity) => _baseRepository.Add(entity);

        public Task AddAsync(TEntity entity) => _baseRepository.AddAsync(entity);

        public void AddMultiple(IEnumerable<TEntity> entities) => _baseRepository.AddMultiple(entities);

        public Task AddMultipleAsync(IEnumerable<TEntity> entities)=> _baseRepository.AddMultipleAsync(entities);

        public IQueryable<TEntityRecover> GetAll<TEntityRecover, Entity>() where TEntityRecover : class where Entity : BaseEntity => _mapper.Map<IQueryable<TEntityRecover>>(_baseRepository.GetAll<Entity>()); 

        public async Task<IQueryable<TEntityRecover>> GetAllAsync<TEntityRecover,Entity>() where TEntityRecover : class where Entity : BaseEntity => _mapper.Map<IQueryable<TEntityRecover>>(await _baseRepository.GetAllAsync<Entity>());

        public TEntityRecover GetById<TEntityRecover, Entity>(Guid id) where TEntityRecover : class where Entity : BaseEntity => _mapper.Map<TEntityRecover>(_baseRepository.GetById<Entity>(id));

        public async Task<TEntityRecover> GetByIdAsync<TEntityRecover, Entity>(Guid id) where TEntityRecover : class where Entity : BaseEntity  => _mapper.Map<TEntityRecover>(await _baseRepository.GetByIdAsync<Entity>(id));

        public List<TEntityRecover> GetList<TEntityRecover, Entity>() where TEntityRecover : class where Entity : BaseEntity=> _mapper.Map<List<TEntityRecover>>(_baseRepository.GetList<Entity>());


        public async Task<List<TEntityRecover>> GetListAsync<TEntityRecover, Entity>() where TEntityRecover : class where Entity : BaseEntity => _mapper.Map<List<TEntityRecover>>(await _baseRepository.GetListAsync<BaseEntity>());

        public void Remove(TEntity entity) => _baseRepository.Remove(entity);

        public void RemoveMultiple(IEnumerable<TEntity> entities) => _baseRepository.RemoveMultiple(entities);

        public void Update(TEntity entity) => _baseRepository.Update(entity);

        public void UpdateMultiple(IEnumerable<TEntity> entities) => _baseRepository.UpdateMultiple(entities);
    }
}
