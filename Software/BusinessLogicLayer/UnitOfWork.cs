using BusinessLogicLayer.Repositories;
using DatabaseLayer;
using DatabaseLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
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

        public int Complete()
        {
            return _appDbContext.SaveChanges();
        }
    }
}
