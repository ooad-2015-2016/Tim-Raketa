
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

        public List<Uposlenik> uposlenici { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigationService NavigationService { get; set; }
        List<Uposlenik> uposlenici1 = new List<Uposlenik>();

       NasaBazaDbContext db = new NasaBazaDbContext();
        public PregledUposlenikaViewModel()
        {
            uposlenici = new List<Uposlenik>();
            uposlenici1.AddRange(db.Uposlenici);
            foreach (Uposlenik o in uposlenici1)
                // if (o.Tip.Equals("UPOSLENIK"))
                uposlenici.Add(o);
            NavigationService = new NavigationService();
        }
    }
}
