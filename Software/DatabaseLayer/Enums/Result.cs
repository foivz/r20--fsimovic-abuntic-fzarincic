using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Enums
{
    /// <summary>
    /// Enumeracija sa 3 moguća ishoda (uspješno, već postoji, neuspješno)
    /// </summary>
    public enum Result
    {
        Success,
        AlreadyExists,
        Unsuccessful
    }
}
