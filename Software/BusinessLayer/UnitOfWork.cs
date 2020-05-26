using BusinessLayer.Repositories;
using DatabaseLayer.Interfaces;
using DatabaseLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UnitOfWork
    {
        protected ClubbingPayDbContext _appDbContext { get; set; }
        public IZaposlenikRepository Zaposlenici { get; set; }

        public UnitOfWork(ClubbingPayDbContext dbContext)
        {
            _appDbContext = dbContext;
            Zaposlenici = new ZaposlenikRepository(_appDbContext);
        }

        public int Complite()
        {
            return _appDbContext.SaveChanges();
        }
    }
}
