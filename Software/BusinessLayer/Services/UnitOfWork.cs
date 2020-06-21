using BusinessLayer.Repositories;
using DatabaseLayer.Interfaces;
using DatabaseLayer.Model;
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
        public IRacunRepository Racuni { get; set; }
        public IStavkaRacuna StavkeRacuna { get; set; }
        public IPrimkaRepository Primke { get; set; }
        public IStavkaPrimke StavkePrimke { get; set; }
        public IUlogaRepository Uloge { get; set; }
        public INarudzbenica Narudzbenica { get; set; }
        public IStavkaNarudzbenice StavkaNarudzbenice { get; set; }

        public UnitOfWork(ClubbingPayDbContext dbContext)
        {
            _appDbContext = dbContext;
            Zaposlenici = new ZaposlenikRepository(_appDbContext);
            KategorijaArtikla = new KategorijaRepository(_appDbContext);
            Artikli = new ArtiklRepository(_appDbContext);
            Dobavljaci = new DobavljacRepository(_appDbContext);
            Racuni = new RacunRepository(_appDbContext);
            StavkeRacuna = new StavkeRacunaRepository(_appDbContext);
            Primke = new PrimkaRepository(_appDbContext);
            StavkePrimke = new StavkaPrimkeRepository(_appDbContext);
            Uloge = new UlogaRepository(_appDbContext);
            Narudzbenica = new NarudzbenicaRepository(_appDbContext);
            StavkaNarudzbenice = new StavkaNarudzbeniceRepository(_appDbContext);
        }

        public int Complete()
        {
            return _appDbContext.SaveChanges();
        }

    }
}
