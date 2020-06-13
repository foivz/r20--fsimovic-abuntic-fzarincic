using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{
    /// <summary>
    /// Enumeracija sa 3 moguća ishoda (uspješno, nije pronađen, neaktivan)
    /// </summary>
    public enum LoginResult
    {
        Succesful,
        NotFound,
        Inactive,
        Null
    }
}
