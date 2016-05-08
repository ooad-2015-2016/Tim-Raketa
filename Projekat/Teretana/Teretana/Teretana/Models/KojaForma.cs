using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teretana.Teretana.Models
{
    public class KojaForma
    {
        public int KojaFormaID { get; set; }
        public string Naziv { get; set; }
        public string Kod { get; set; }
        public Type Podstranica { get; set; } //Koristi se kao Navigacija ka stavci menija odnosno podstranici koju otvara

        //Dio modela predviđen za nadogradnju sa EntityFramework-om
        public virtual ICollection<UlogaUProgramu> UlogaUProgramu
        {
            get;
            set;
        }
    }
}
