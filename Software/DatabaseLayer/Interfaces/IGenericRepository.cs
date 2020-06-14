using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        Task<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        List<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        void Update(TEntity entity);
    }
}
