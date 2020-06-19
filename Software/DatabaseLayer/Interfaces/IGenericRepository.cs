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
        TEntity Find(Expression<Func<TEntity, bool>> predicate);
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Update(TEntity entity);
    }
}
