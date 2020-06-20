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
    public class NarudzbenicaRepository : GenericRepository<Narudzbenica>, INarudzbenica
    {
        private ClubbingPayDbContext _dbContext { get; set; }

        public NarudzbenicaRepository(ClubbingPayDbContext appDbContext)
            : base(appDbContext)
        {
            _dbContext = _appDbContext;
        }
    }
}
