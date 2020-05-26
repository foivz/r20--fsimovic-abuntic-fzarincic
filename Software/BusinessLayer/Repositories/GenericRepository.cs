using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected ClubbingPayDbContext _appDbContext { get; set; }

        public GenericRepository(ClubbingPayDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task Add(TEntity entity)
        {
            //TODO - povratni tip Result
            await _appDbContext.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            //TODO - povratni tip Result
            _appDbContext.Remove(entity);
        }

        public async Task<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            //return await _appDbContext.Set<TEntity>().FindAsync(predicate);
            return await _appDbContext.Set<TEntity>().SingleOrDefaultAsync(predicate);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _appDbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _appDbContext.Set<TEntity>().FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            //TODO - povratni tip Result
            _appDbContext.Set<TEntity>().Update(entity);
        }
    }
}
