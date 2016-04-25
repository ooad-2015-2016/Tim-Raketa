
namespace Teretana.TeretanaBaza.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Osoba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OsobaId { get; set; }//primary key u bazi
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string JMBG { get; set; }
        public string MjestoStanovanja { get; set; }
        public string Email { get; set; }        public enum Spol { muski, zenski };        public Spol SpolOsobe { get; set; }
    }
}
