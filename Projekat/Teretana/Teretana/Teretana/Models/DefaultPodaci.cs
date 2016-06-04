using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teretana.TeretanaBaza.Models
{
    class DefaultPodaci
    {
        public static void Initialize(NasaBazaDbContext context)
        {
            
            if (!context.Gosti.Any())
            {
                context.Gosti.AddRange(
                new Gost()
                {
                    GostID = 1, ImeIPrezime = "Emina Gost"
                }
                );
                context.SaveChanges();
            }
            if (!context.Osobe.Any())
            {
                
                context.Osobe.AddRange( 
                new Osoba()
                {
                    Ime = "Emina",
                    Prezime = "Uposlenik",
                    DatumRodjenja = new DateTime(1990, 1, 1),
                    OsobaId = 1,
                    Email = "emina@emina.com",
                    JMBG = "11111111",
                    MjestoStanovanja = "Sarajevo",
                    SpolOsobe = true,
                    Password = "1234",
                    Tip = "UPOSLENIK"
                }
                );
                context.SaveChanges();
            }
            if (!context.Programi.Any())
            {
                context.Programi.AddRange(
                new Program()
                {
                    ProgramId = 1,
                    NazivPrograma = "Program1",
                    OpisPrograma = "Ovo je program1",
                    CijenaClanarine = 20
                }
                );
                context.SaveChanges();
            }
            
        }
    }
}
