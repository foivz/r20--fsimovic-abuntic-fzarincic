using BusinessLayer.Services;
using DatabaseLayer.Interfaces;
using DatabaseLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repositories
{
    /// <summary>
    /// Klasa ZaposlenikRepository nasljeđuje generičke metode klase GenericRepository te implementira svoje.
    /// </summary>
    public class ZaposlenikRepository : GenericRepository<Zaposlenik>, IZaposlenikRepository
    {
        private ClubbingPayDbContext _dbContext { get; set; }

        public ZaposlenikRepository(ClubbingPayDbContext appDbContext)
            : base(appDbContext)
        {
            _dbContext = _appDbContext;
        }

        /// <summary>
        /// Metoda PronadiZaposlenika pronalazi zaposlenika u bazi.
        /// </summary>
        /// <param name="user">user = username zaposlenika</param>
        /// <param name="password">password = password zaposlenika</param>
        /// <returns>Vraća pronađenog zaposlenika.</returns>
        public Zaposlenik PronadiZaposlenika(string user, string password)
        {
            return _dbContext.Zaposlenici.FirstOrDefault(z => z.KorisnickoIme == user && z.LozinkaHash == password);
        }

        /// <summary>
        /// Metoda UsporediOIB traži postoji li taj korisnik u bazi prema prosljeđenom oibu iz forme za registraciju.
        /// </summary>
        /// <param name="oib">prosljeđeni oib sa forme</param>
        /// <returns>ture/false</returns>
        public bool UsporediOIB(string oib)
        {
            return _dbContext.Zaposlenici.Select(x => x.OIB).Contains(oib) ? true : false;
        }

        /// <summary>
        /// Metoda UsporediKorisnickoIme gleda je li korisničko ime već zauzeto.
        /// </summary>
        /// <param name="korisnickoIme">prosljeđeno korisničko ime s forme za registraciju</param>
        /// <returns>true/false</returns>
        public bool UsporediKorisnickoIme(string korisnickoIme)
        {
            return _dbContext.Zaposlenici.Select(x => x.KorisnickoIme).Contains(korisnickoIme) ? true : false;
        }

        public int DohvatiIdKorisnika(string oib)
        {
            return _dbContext.Zaposlenici.Where(w => w.OIB == oib).Select(s => s.Id).FirstOrDefault();
        }
    }
}
