﻿
namespace Teretana.TeretanaBaza.Models
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Korisnik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string JMBG { get; set; }
        public string MjestoStanovanja { get; set; }
        public string Email { get; set; }
        public bool SpolOsobe { get; set; }
        public string RFID { get; set; }
        public int ProgramID { get; set; }

        /* NasaBazaDbContext db = new NasaBazaDbContext();
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         public int KorisnikID { get; set; }
         Program ProgramTeretane { get; set; }
         public long create(Korisnik entity)
         {
             db.Korisnici.Add(entity);
             db.SaveChanges();
             foreach (Korisnik a in db.Korisnici)
                 if (a.JMBG.Equals(entity.JMBG))
                     return a.KorisnikID;
             return 0;
         }

         public void delete(Korisnik entity)
         {
             foreach (Korisnik a in db.Korisnici)
                 if (entity.KorisnikID == a.KorisnikID)
                 {
                     db.Korisnici.Remove(a);
                 }
         }

         public List<Korisnik> getAll()
         {
             List<Korisnik> lista = new List<Korisnik>();
             foreach (Korisnik a in db.Korisnici)
                 lista.Add(a);
             return lista;
         }

         public List<Korisnik> getByExample(string name, string value)
         {
             throw new NotImplementedException();
         }

         public Korisnik getById(int id)
         {
             Korisnik admin = new Korisnik();
             foreach (Korisnik a in db.Korisnici)
                 if (a.KorisnikID == id)
                     admin = a;
             return admin;
         }

         public Korisnik read(Korisnik entity)
         {
             throw new NotImplementedException();
         }

         public Korisnik update(Korisnik entity)
         {
             //nista
             return null;

         }
     }*/
    }
}
