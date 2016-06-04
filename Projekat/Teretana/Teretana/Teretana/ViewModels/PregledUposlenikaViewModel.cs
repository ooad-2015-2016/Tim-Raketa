
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
    class PregledUposlenikaViewModel : INotifyPropertyChanged
    {

        public List<Osoba> uposlenici { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigationService NavigationService { get; set; }
        List<Osoba> uposlenici1 = new List<Osoba>();

        NasaBazaDbContext db = new NasaBazaDbContext();
        public PregledUposlenikaViewModel()
        {
            uposlenici = new List<Osoba>();
            uposlenici1.AddRange(db.Osobe);
            foreach (Osoba o in uposlenici1)
                // if (o.Tip.Equals("UPOSLENIK"))
                uposlenici.Add(o);
            NavigationService = new NavigationService();
        }
    }
}
