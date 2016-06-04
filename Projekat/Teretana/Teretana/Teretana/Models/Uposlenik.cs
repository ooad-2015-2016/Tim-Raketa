

namespace Teretana.TeretanaBaza.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Uposlenik
    {
        
        
       /* public void create(Uposlenik entity)
        {
            db.Osobe.AddRange(entity);
            db.SaveChanges();
           /* foreach (Uposlenik a in db.Uposlenici)
                if (a.JMBG.Equals(entity.JMBG))
                    return a.UposlenikID;
            return 0;
        }

        public void delete(Uposlenik entity)
        {
            foreach (Uposlenik a in db.Osobe)
                if (entity.OsobaId == a.OsobaId)
                {
                    db.Osobe.Remove(a);
                }
        }*/ 
        
        /*
        public List<Uposlenik> getAll()
        {
            List<Uposlenik> lista = new List<Uposlenik>();
            foreach (Uposlenik a in db.Osobe)
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
            foreach (Uposlenik a in db.Osobe)
                if (a.OsobaId == id)
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

        }*/
    }
}
