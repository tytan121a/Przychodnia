using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia.models
{
    public class Permission
    {
        public int IdUprawnienia { get; set; }
        public string Uprawnienie { get; set; }
        public string OpisUprawnienia { get; set; }
    }
}
