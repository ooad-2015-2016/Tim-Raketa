using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teretana.Teretana.Models
{
    public class UlogaUProgramu
    {
        public int UlogaId { get; set; }
        public int KojaFormaID { get; set; }
        public Uloga Uloga { get; set; }
        public KojaForma KojaForma { get; set; }

        public UlogaUProgramu(Uloga uloga, KojaForma kojaForma)
        {
            this.Uloga = uloga;
            this.KojaForma = kojaForma;
            this.UlogaId = uloga.UlogaId;
            this.KojaFormaID = kojaForma.KojaFormaID;
        }
    }
}
