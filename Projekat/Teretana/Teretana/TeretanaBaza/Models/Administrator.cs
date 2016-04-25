
namespace Teretana.TeretanaBaza.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;
    class Administrator : Osoba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdministratorID { get; set; }
        public string Password { get; set; }
    }
}
