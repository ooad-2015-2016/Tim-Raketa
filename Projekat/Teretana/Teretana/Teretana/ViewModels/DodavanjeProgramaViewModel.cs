using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Teretana.Teretana.Helper;
using Teretana.Teretana.Views;
using Teretana.TeretanaBaza.Models;
using Windows.UI.Popups;

namespace Teretana.Teretana.ViewModels
{
    class DodavanjeProgramaViewModel : INotifyPropertyChanged
    {
        public TeretanaBaza.Models.Program Program { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public INavigationService NavigationService { get; set; }
        public ICommand dodajProgram { get; set; }
        NasaBazaDbContext db = new NasaBazaDbContext();
        public DodavanjeProgramaViewModel()
        {
            Program = new TeretanaBaza.Models.Program();
            NavigationService = new NavigationService();
            dodajProgram = new RelayCommand<object>(dodavanjeUposlenika, mozeLiSeDodati);
        }
        public async void dodavanjeUposlenika(object parametar)
        {

            db.Programi.AddRange(Program);
            db.SaveChanges();
            var dialog = new MessageDialog("Uspješno ste dodali program!");
            await dialog.ShowAsync();
            //prebacuje na sljedeci view i proslijedjuje viewmodel za taj view, koji ima ovaj view (this) kao Parent
            NavigationService.Navigate(typeof(PregledProgramaPage), null);
        }
        public bool mozeLiSeDodati(object parametar)
        {
            return true;
        }
    }
}