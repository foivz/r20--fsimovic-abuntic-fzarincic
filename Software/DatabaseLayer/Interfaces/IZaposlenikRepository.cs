using DatabaseLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Interfaces
{
    public interface IZaposlenikRepository : IGenericRepository<Zaposlenik>
    {
        /// <summary>
        /// Funkcija koja vraća zaposlenika na temelju usera i passworda.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns>Zaposlenik</returns>
        Zaposlenik PronadiZaposlenika(string user, string password);
    }
}
