﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Rent_A_Car.WebAPI.Database
{
    public partial class Klijent
    {
        public Klijent()
        {
            Rezervacijas = new HashSet<Rezervacija>();
        }

        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTel { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string DatumRodjenja { get; set; }
        public int? GradId { get; set; }
        public int? KorisnickiNalogId { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public string KorisnickoIme { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual KorisnickiNalog KorisnickiNalog { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
    }
}
