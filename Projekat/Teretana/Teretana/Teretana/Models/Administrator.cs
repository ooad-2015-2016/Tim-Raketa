
namespace Teretana.TeretanaBaza.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;
    using CB.Data.Common.CRUD;
  
    class Administrator : Osoba
    {
        NasaBazaDbContext db;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdministratorID { get; set; }
        public string Password { get; set; }
        public long create(Administrator a)
        {
            db.Administratori.Add(a);
            db.SaveChanges();
            return a.AdministratorID;
        }
        
        
    }
}
