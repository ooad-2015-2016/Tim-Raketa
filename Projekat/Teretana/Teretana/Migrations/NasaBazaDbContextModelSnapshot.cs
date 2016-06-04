using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Teretana.TeretanaBaza.Models;

namespace TeretanaMigrations
{
    [ContextType(typeof(NasaBazaDbContext))]
    partial class NasaBazaDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("Teretana.TeretanaBaza.Models.Gost", b =>
                {
                    b.Property<int>("GostID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImeIPrezime");

                    b.Key("GostID");
                });

            builder.Entity("Teretana.TeretanaBaza.Models.Korisnik", b =>
                {
                    b.Property<int>("KorisnikID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<string>("JMBG");

                    b.Property<string>("MjestoStanovanja");

                    b.Property<int>("OsobaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("Prezime");

                    b.Property<string>("RFID");

                    b.Property<bool>("SpolOsobe");

                    b.Property<string>("Tip");

                    b.Key("KorisnikID");
                });

            builder.Entity("Teretana.TeretanaBaza.Models.Osoba", b =>
                {
                    b.Property<int>("OsobaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<string>("JMBG");

                    b.Property<string>("MjestoStanovanja");

                    b.Property<string>("Password");

                    b.Property<string>("Prezime");

                    b.Property<bool>("SpolOsobe");

                    b.Property<string>("Tip");

                    b.Key("OsobaId");
                });

            builder.Entity("Teretana.TeretanaBaza.Models.Program", b =>
                {
                    b.Property<int>("ProgramId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("CijenaClanarine");

                    b.Property<string>("NazivPrograma");

                    b.Property<string>("OpisPrograma");

                    b.Key("ProgramId");
                });
        }
    }
}
