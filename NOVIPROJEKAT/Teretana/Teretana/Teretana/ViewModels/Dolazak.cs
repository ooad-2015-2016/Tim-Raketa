using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teretana.Teretana.Views;
using Teretana.TeretanaBaza.Models;

namespace Teretana.Teretana.ViewModels
{
    class Dolazak
    {
        RFIDViewModel parent = new RFIDViewModel();
        Korisnik korisnik
        {
            get; set;
        }
        public Dolazak()
        {
            korisnik = new Korisnik();
            korisnik = parent.Korisnik;
        }
    }
}
