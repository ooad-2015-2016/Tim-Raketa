
namespace Teretana.TeretanaBaza.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;
    using CB.Data.Common.CRUD;

    class Administrator : Osoba, IDaoCrud<Administrator>
    {
        NasaBazaDbContext db;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdministratorID { get; set; }
        public string Password { get; set; }

        public long create(Administrator entity)
        {
            db.Administratori.Add(entity);
            db.SaveChanges();
            foreach (Administrator a in db.Administratori)
                if (a.JMBG.Equals(entity.JMBG))
                    return a.AdministratorID;
            return 0;
        }

        public void delete(Administrator entity)
        {
            foreach (Administrator a in db.Administratori)
                if (entity.AdministratorID == a.AdministratorID)
                {
                    db.Administratori.Remove(a);
                }
        }

        public List<Administrator> getAll()
        {
            List<Administrator> lista = new List<Administrator>();
            foreach (Administrator a in db.Administratori)
                lista.Add(a);
            return lista;
        }

        public List<Administrator> getByExample(string name, string value)
        {
            throw new NotImplementedException();
        }

        public Administrator getById(int id)
        {
            Administrator admin = new Administrator();
            foreach (Administrator a in db.Administratori)
                if (a.AdministratorID == id)
                    admin = a;
            return admin;
        }

        public Administrator read(Administrator entity)
        {
            throw new NotImplementedException();
        }

        public Administrator update(Administrator entity)
        {
            //nista
            return null;

        }
    }
}
