using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teretana.Teretana.Helper;
using Teretana.TeretanaBaza.Models;

namespace Teretana.Teretana.ViewModels
{
    class PregledKorisnikaViewModel : INotifyPropertyChanged
    {
        
        public List<Korisnik> korisnici { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigationService NavigationService { get; set; }
        NasaBazaDbContext db = new NasaBazaDbContext();
        public PregledKorisnikaViewModel()
        {
            korisnici = new List<Korisnik>();
            foreach (Korisnik k in db.Korisnici)
                korisnici.Add(k);
            NavigationService = new NavigationService();
        }
    }
}
