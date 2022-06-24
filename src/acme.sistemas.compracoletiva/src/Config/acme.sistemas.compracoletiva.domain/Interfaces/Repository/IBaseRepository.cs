using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Interfaces.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task AddAsync(TEntity entity);
        void Add(TEntity entity);
        void AddMultiple(IEnumerable<TEntity> entities);
        Task AddMultipleAsync(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveMultiple(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void UpdateMultiple(IEnumerable<TEntity> entities);
        Task<TEntity> GetByIdAsync(Guid id);
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAll();
        Task<IQueryable<TEntity>> GetAllAsync();
        List<TEntity> GetList();
        Task<List<TEntity>> GetListAsync();
    }
}
