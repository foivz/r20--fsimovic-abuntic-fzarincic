using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DatabaseLayer.Interfaces
{
    public interface IGenericRepository<TEntity>
    {
        Task Add(TEntity entity);
        void Delete(TEntity entity);
        Task<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        void Update(TEntity entity);
    }
}