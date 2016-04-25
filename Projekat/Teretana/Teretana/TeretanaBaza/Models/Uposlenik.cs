

namespace Teretana.TeretanaBaza.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    class Uposlenik : Osoba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UposlenikID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
