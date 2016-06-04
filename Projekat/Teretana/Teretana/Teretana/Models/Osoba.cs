
namespace Teretana.TeretanaBaza.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Osoba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OsobaId { get; set; }//primary key u bazi
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string JMBG { get; set; }
        public string MjestoStanovanja { get; set; }
        public string Email { get; set; }
        public enum Spol { muski, zenski };
        public bool SpolOsobe { get; set; }
        public string Tip { get; set; }
        public string Password { get; set; }

        
    }
}
