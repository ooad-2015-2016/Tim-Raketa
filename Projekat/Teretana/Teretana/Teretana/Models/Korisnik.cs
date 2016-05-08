
namespace Teretana.TeretanaBaza.Models
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Korisnik : Osoba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KorisnikID { get; set; }
        Program ProgramTeretane { get; set; }
    }
}
