

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
        NasaBazaDbContext db = new NasaBazaDbContext();
        public long create(Uposlenik entity)
        {
            db.Uposlenici.Add(entity);
            db.SaveChanges();
            foreach (Uposlenik a in db.Uposlenici)
                if (a.JMBG.Equals(entity.JMBG))
                    return a.UposlenikID;
            return 0;
        }

        public void delete(Uposlenik entity)
        {
            foreach (Uposlenik a in db.Uposlenici)
                if (entity.UposlenikID == a.UposlenikID)
                {
                    db.Uposlenici.Remove(a);
                }
        }

        public List<Uposlenik> getAll()
        {
            List<Uposlenik> lista = new List<Uposlenik>();
            foreach (Uposlenik a in db.Uposlenici)
                lista.Add(a);
            return lista;
        }

        public List<Uposlenik> getByExample(string name, string value)
        {
            throw new NotImplementedException();
        }

        public Uposlenik getById(int id)
        {
            Uposlenik admin = new Uposlenik();
            foreach (Uposlenik a in db.Uposlenici)
                if (a.UposlenikID == id)
                    admin = a;
            return admin;
        }

        public Uposlenik read(Uposlenik entity)
        {
            throw new NotImplementedException();
        }

        public Uposlenik update(Uposlenik entity)
        {
            //nista
            return null;

        }
    }
}
