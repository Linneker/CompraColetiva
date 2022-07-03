using acme.sistemas.compracoletiva.domain.Entity;
using acme.sistemas.compracoletiva.domain.Interfaces.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.core.Interfaces.Service
{
    public interface IBaseService<TEntity> where TEntity : IAggregateRoot
    {
        Task AddAsync(TEntity entity);
        void Add(TEntity entity);
        void AddMultiple(IEnumerable<TEntity> entities);
        Task AddMultipleAsync(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveMultiple(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void UpdateMultiple(IEnumerable<TEntity> entities);
        Task<TEntityRecover> GetByIdAsync<TEntityRecover, Entity>(Guid id) where TEntityRecover : class where Entity : BaseEntity;
        TEntityRecover GetById<TEntityRecover, Entity>(Guid id) where TEntityRecover : class where Entity : BaseEntity;
        IQueryable<TEntityRecover> GetAll<TEntityRecover, Entity>() where TEntityRecover : class where Entity : BaseEntity;
        Task<IQueryable<TEntityRecover>> GetAllAsync<TEntityRecover, Entity>() where TEntityRecover : class where Entity : BaseEntity;
        List<TEntityRecover> GetList<TEntityRecover, Entity>() where TEntityRecover : class where Entity : BaseEntity;
        Task<List<TEntityRecover>> GetListAsync<TEntityRecover, Entity>() where TEntityRecover : class where Entity : BaseEntity;
    }
}
