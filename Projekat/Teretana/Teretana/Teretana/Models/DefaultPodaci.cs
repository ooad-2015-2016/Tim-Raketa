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
            if (!context.Administratori.Any())
            {
                context.Administratori.AddRange(
                new Administrator()
                {
                    Ime = "Admin",
                    Prezime = "Admin",
                    DatumRodjenja = new DateTime(1990, 1, 1),
                    AdministratorID = 1,
                    Email = "admin@admin.com",
                    JMBG = "11111111",
                    MjestoStanovanja = "MjestoAdmina",
                    OsobaId = 1,
                    Password = "adminadmin",
                    SpolOsobe = Osoba.Spol.muski
                }
                );
                context.SaveChanges();
            }
            if (!context.Gosti.Any())
            {
                context.Gosti.AddRange(
                new Gost()
                {
                    GostID = 1, ImeIPrezime = "Gost Goscic"
                }
                );
                context.SaveChanges();
            }
            if (!context.Osobe.Any())
            {
                context.Osobe.AddRange(
                new Osoba()
                {
                    Ime = "Osoba",
                    Prezime = "Osoba",
                    DatumRodjenja = new DateTime(1990, 1, 1),
                    Email = "admin@admin.com",
                    JMBG = "11111111",
                    MjestoStanovanja = "MjestoAdmina",
                    OsobaId = 1,
                    SpolOsobe = Osoba.Spol.muski
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
            if (!context.Uposlenici.Any())
            {
                context.Uposlenici.AddRange(
                new Uposlenik()
                {
                    Ime = "Uposlenik",
                    Prezime = "Uposlenik",
                    DatumRodjenja = new DateTime(1990, 1, 1),
                    UposlenikID = 1,
                    Email = "admin@admin.com",
                    JMBG = "11111111",
                    MjestoStanovanja = "MjestoAdmina",
                    OsobaId = 1,
                    Password = "1234",
                    SpolOsobe = Osoba.Spol.muski,
                    Username = "uposlenik"
                }
                );
                context.SaveChanges();
            }
        }
    }
}
