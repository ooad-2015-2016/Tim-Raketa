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
    class PregledProgramaViewModel : INotifyPropertyChanged
    {

        public List<TeretanaBaza.Models.Program> programi { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigationService NavigationService { get; set; }
        NasaBazaDbContext db = new NasaBazaDbContext();
        public PregledProgramaViewModel()
        {
            programi = new List<TeretanaBaza.Models.Program>();
            foreach (TeretanaBaza.Models.Program p in db.Programi)
                programi.Add(p);
            NavigationService = new NavigationService();
        }
    }
}
