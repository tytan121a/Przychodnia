using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia.models
{
    public class Address
    {
        public int IdAdresu { get; set; }
        public string Miejscowosc { get; set; }
        public string KodPocztowy { get; set; }
        public string Ulica { get; set; }
        public string NrPosesji { get; set; }
        public string NrLokalu { get; set; }
    }
}
