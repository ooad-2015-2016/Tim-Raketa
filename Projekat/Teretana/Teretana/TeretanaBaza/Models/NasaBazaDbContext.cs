using Microsoft.Data.Entity;
using Microsoft.Data.SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Teretana.TeretanaBaza.Models
{
    class NasaBazaDbContext : DbContext
    {
        public DbSet<Program> Programi { get; set; }
        public DbSet<Administrator> Administratori { get; set; }
        public DbSet<Gost> Gosti { get; set; }
        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<Uposlenik> Uposlenici { get; set; }
        
        //VI URADITE OVAJ CONTEXT i migraciju, KOD MENE JAVLJA GREŠKU ... Emina :) 
        
    }
}
