using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teretana.Teretana.Models
{
    public class Uloga
    {
        public int UlogaId { get; set; }
        public string Naziv { get; set; }

        public ICollection<UlogaUProgramu> UlogaUProgramu
        {
            get;
            set;
        }
        public Uloga()
        {
            UlogaUProgramu = new List<UlogaUProgramu>();
        }
        //pridruzivanje MeniStavkeUlozi
        public void DodajMeniStavkuUlozi(KojaForma menistavka)
        {
            this.UlogaUProgramu.Add(new UlogaUProgramu(this, menistavka));
        }
    }
}
