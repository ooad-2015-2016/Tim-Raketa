
namespace Teretana.TeretanaBaza.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;
    using CB.Data.Common.CRUD;

    class Gost : IDaoCrud<Gost>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GostID { get; set; }
        public string ImeIPrezime { get; set; }

        NasaBazaDbContext db = new NasaBazaDbContext();
        public long create(Gost entity)
        {
            db.Gosti.Add(entity);
            db.SaveChanges();
            foreach (Gost a in db.Gosti)
                if (a.ImeIPrezime.Equals(entity.ImeIPrezime))
                    return a.GostID;
            return 0;
        }

        public void delete(Gost entity)
        {
            foreach (Gost a in db.Gosti)
                if (entity.GostID == a.GostID)
                {
                    db.Gosti.Remove(a);
                }
        }

        public List<Gost> getAll()
        {
            List<Gost> lista = new List<Gost>();
            foreach (Gost a in db.Gosti)
                lista.Add(a);
            return lista;
        }

        public List<Gost> getByExample(string name, string value)
        {
            throw new NotImplementedException();
        }

        public Gost getById(int id)
        {
            Gost admin = new Gost();
            foreach (Gost a in db.Gosti)
                if (a.GostID == id)
                    admin = a;
            return admin;
        }

        public Gost read(Gost entity)
        {
            throw new NotImplementedException();
        }

        public Gost update(Gost entity)
        {
            //nista
            return null;

        }
    }
}
