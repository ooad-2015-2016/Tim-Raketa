
namespace Teretana.TeretanaBaza.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    class Gost
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GostID { get; set; }
        public string ImeIPrezime { get; set; }
    }
}
