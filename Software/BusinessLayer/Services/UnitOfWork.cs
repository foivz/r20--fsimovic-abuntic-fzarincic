using BusinessLayer.Repositories;
using DatabaseLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        protected ClubbingPayDbContext _appDbContext { get; set; }
        public IZaposlenikRepository Zaposlenici { get; set; }
        public IKategorijaArtiklaRepository KategorijaArtikla { get; set; }
        public IArtiklRepository Artikli { get; set; }
        public IDobavljacRepository Dobavljaci { get; set; }
        public UnitOfWork(ClubbingPayDbContext dbContext)
        {
            _appDbContext = dbContext;
            Zaposlenici = new ZaposlenikRepository(_appDbContext);
            KategorijaArtikla = new KategorijaRepository(_appDbContext);
            Artikli = new ArtiklRepository(_appDbContext);
            Dobavljaci = new DobavljacRepository(_appDbContext);
        }

        public int Complete()
        {
            return _appDbContext.SaveChanges();
        }

    }
}
