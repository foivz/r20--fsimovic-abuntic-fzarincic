﻿using DatabaseLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Interfaces
{
    public interface IZaposlenikRepository : IGenericRepository<Zaposlenik>
    {
        Zaposlenik PronadiZaposlenika(string user, string password);
        bool ProvjeriPostojanostOIBa(string oib);
        bool ProvjeriZauzetostKorisnickogImena(string korisnickoIme);
        Zaposlenik DohvatiZaposlenikaSUlogom(string oib);
        List<Zaposlenik> DohvatiSveZaposlenikSUlogom();
    }
}
