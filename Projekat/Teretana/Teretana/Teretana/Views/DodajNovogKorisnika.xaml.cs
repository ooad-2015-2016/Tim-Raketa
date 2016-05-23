using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Teretana.Teretana.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DodajNovogKorisnika : Page
    {
        public DodajNovogKorisnika()
        {
            this.InitializeComponent();
        }

        private async void klik(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("Uspješno dodan korisnik");
            await dialog.ShowAsync();
        }

        private void klikklik(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UposlenikPage), null);
        }
    }
}
