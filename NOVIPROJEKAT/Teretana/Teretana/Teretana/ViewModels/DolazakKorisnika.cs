using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Teretana.Teretana.Helper;
using Teretana.TeretanaBaza.Models;

namespace Teretana.Teretana.ViewModels
{
    class DolazakKorisnika : INotifyPropertyChanged
    {
        public Korisnik Korisnik { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigationService NavigationService { get; set; }
        public ICommand dodajUposlenika { get; set; }
        NasaBazaDbContext db;
    }
}