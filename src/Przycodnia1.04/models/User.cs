﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia.models
{
    public class User
    {
        public int IdUzytkownika { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int IdAdresu { get; set; }
        public string Pesel { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public int IdPlci { get; set; }
        public string Email { get; set; }
        public string NrTelefonu { get; set; }
        public bool CzyZapomniany { get; set; }
        public DateTime? DataZapomnienia { get; set; }
        public int? KtoZapomnial { get; set; }
        public int IdRoli { get; set; }
        public int BledneLogowania { get; set; }
        public DateTime? ZablokowaneDo { get; set; }
        public bool HasloOstatnioZmienione { get; set; }
    }
}
