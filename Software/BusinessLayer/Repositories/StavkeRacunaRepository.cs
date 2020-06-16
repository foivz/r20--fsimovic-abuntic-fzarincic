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
    public class StavkeRacunaRepository : GenericRepository<StavkaRacuna>, IStavkaRacuna
    {
        private ClubbingPayDbContext _dbContext { get; set; }

        public StavkeRacunaRepository(ClubbingPayDbContext appDbContext)
            : base(appDbContext)
        {
            _dbContext = _appDbContext;
        }
    }
}
