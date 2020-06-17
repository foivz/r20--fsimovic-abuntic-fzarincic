using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public static class IzracunPorezaServices
    {
        public static double IzracunajUkupno(double osnovica)
        {
            double ukupno = osnovica + IzracunajPorezNaPotrosnju(osnovica) + IzracunajPorezNaDodanuVrijednost(osnovica);
            return ukupno;
        }

        public static double IzracunajPorezNaDodanuVrijednost(double osnovica)
        {
            double pdv = (0.25 * osnovica);
            return pdv;
        }

        public static double IzracunajPorezNaPotrosnju(double osnovica)
        {
            double pnp = (0.03 * osnovica);
            return pnp;
        }
    }
}
