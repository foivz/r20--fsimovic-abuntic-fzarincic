﻿using BusinessLayer.Services;
using DatabaseLayer.Interfaces;
using DatabaseLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repositories
{
    public class RacunRepository : GenericRepository<Racun>, IRacunRepository
    {
        private ClubbingPayDbContext _dbContext { get; set; }

        public RacunRepository(ClubbingPayDbContext appDbContext) 
            : base(appDbContext)
        {
            _dbContext = _appDbContext;
        }
    }
}
