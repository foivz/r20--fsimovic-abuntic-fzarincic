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
    public class DobavljacRepository: GenericRepository<Dobavljac>, IDobavljacRepository
    {
        private ClubbingPayDbContext _dbContext { get; set; }

        public DobavljacRepository(ClubbingPayDbContext appDbContext)
            : base(appDbContext)
        {
            _dbContext = _appDbContext;
        }
    }
}