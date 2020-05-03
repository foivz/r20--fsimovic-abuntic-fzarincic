using DatabaseLayer;
using DatabaseLayer.Interfaces;
using DatabaseLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repositories
{
    public class ZaposlenikRepository : GenericRepository<Zaposlenik>, IZaposlenikRepository
    {
        private ClubbingPayDbContext _dbContext { get; set; }

        public ZaposlenikRepository(ClubbingPayDbContext clubbingPayDbContext)
            : base (clubbingPayDbContext)
        {

        }

        public Zaposlenik PronadiZaposlenika(string user, string password)
        {
            return _dbContext.Zaposlenici.FirstOrDefault(z => z.KorisnickoIme == user && z.LozinkaHash == password);
        }
        
    }
}
