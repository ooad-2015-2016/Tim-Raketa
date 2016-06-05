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
    class PregledGostijuViewModel : INotifyPropertyChanged
    {

        public List<Gost> gosti { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigationService NavigationService { get; set; }
        NasaBazaDbContext db = new NasaBazaDbContext();
        public PregledGostijuViewModel()
        {
            gosti = new List<Gost>();
            foreach (Gost g in db.Gosti)
                gosti.Add(g);
            NavigationService = new NavigationService();
        }
    }
}