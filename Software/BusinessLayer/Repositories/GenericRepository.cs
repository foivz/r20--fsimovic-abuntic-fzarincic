﻿using BusinessLayer.Services;
using DatabaseLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repositories
{
    /// <summary>
    /// Klasa GenericRepository sadžava sve predefinirane generičke metode za slanjem zahtjeva prema bazi.
    /// </summary>
    /// <typeparam name="TEntity">TEntity je zapis nad kojim se vrše operacije. Npr. za zaposlenika koristimo zapis zaposlenika.</typeparam>
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected ClubbingPayDbContext _appDbContext { get; set; }

        public GenericRepository(ClubbingPayDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        /// <summary>
        /// Metoda Add dodaje novi zapis u bazu.
        /// </summary>
        /// <param name="entity">entity = zapis koji dodajemo u bazu</param>
        /// <returns></returns>
        public void Add(TEntity entity)
        {
            _appDbContext.Add(entity);
        }

        /// <summary>
        /// Metoda Delete birše zapis iz baze.
        /// </summary>
        /// <param name="entity">entity = zapis koji brišemo iz baze</param>
        public void Delete(TEntity entity)
        {
            _appDbContext.Remove(entity);
        }

        /// <summary>
        /// Metoda Find pretražuje zapis u bazi prema prosljeđenom upitu.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public TEntity Find(Expression<Func<TEntity, bool>> predicate)
        {
            //return await _appDbContext.Set<TEntity>().FindAsync(predicate);
            return _appDbContext.Set<TEntity>().SingleOrDefault(predicate);
        }

        /// <summary>
        /// Metoda GetAll dosvaća sve zapise.
        /// </summary>
        /// <returns>Vraća sve dohvaćene zapise u obliku liste.</returns>
        public List<TEntity> GetAll()
        {
            return _appDbContext.Set<TEntity>().ToList() as List<TEntity>;
        }

        public List<TEntity> GetAll(TEntity entity)
        {
            return _appDbContext.Set<TEntity>().ToList() as List<TEntity>;
        }

        /// <summary>
        /// Metoda GetById dohvaća zapis po id-u.
        /// </summary>
        /// <param name="id">id = id zapisa</param>
        /// <returns>Vraća zapis.</returns>
        public TEntity GetById(int id)
        {
            return _appDbContext.Set<TEntity>().Find(id);
        }

        /// <summary>
        /// Metoda Update mijenja zapis u bazi.
        /// </summary>
        /// <param name="entity">entity = zapis za promjenu</param>
        public void Update(TEntity entity)
        {
            _appDbContext.Set<TEntity>().Update(entity);
        }
    }
}
