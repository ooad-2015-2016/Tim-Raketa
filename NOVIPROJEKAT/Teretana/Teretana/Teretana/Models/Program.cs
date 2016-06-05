
namespace Teretana.TeretanaBaza.Models
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Program
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProgramId { get; set; }//primary key u bazi
        public string NazivPrograma { get; set; }
        public string OpisPrograma { get; set; }
        public decimal CijenaClanarine { get; set; }

    }
}
