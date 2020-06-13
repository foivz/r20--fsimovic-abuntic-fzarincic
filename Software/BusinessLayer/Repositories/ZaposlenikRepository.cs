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
    }
}
