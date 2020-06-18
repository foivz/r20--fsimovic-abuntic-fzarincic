using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Model
{
    /// <summary>
    /// Klasa Primka
    /// </summary>
    public class Primka
    {
        #region [Mapped properties]
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int Odgoda { get; set; }
        public string Napomena { get; set; }
        public Zaposlenik Zaposlenik { get; set; }
        public Dobavljac Dobavljac { get; set; }
        public List<StavkaPrimke> StavkaPrimke { get; set; }
        #endregion

        public Primka()
        {
            StavkaPrimke = new List<StavkaPrimke>();
        }
    }
}
