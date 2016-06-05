using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Teretana.TeretanaBaza.Models;

namespace TeretanaMigrations
{
    [ContextType(typeof(NasaBazaDbContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20160605161349_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
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

                    b.Property<string>("Prezime");

                    b.Property<int>("ProgramID");

                    b.Property<string>("RFID");

                    b.Property<bool>("SpolOsobe");

                    b.Key("KorisnikID");
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

            builder.Entity("Teretana.TeretanaBaza.Models.Uposlenik", b =>
                {
                    b.Property<int>("UposlenikID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<string>("JMBG");

                    b.Property<string>("MjestoStanovanja");

                    b.Property<string>("Password");

                    b.Property<string>("Prezime");

                    b.Property<bool>("SpolOsobe");

                    b.Key("UposlenikID");
                });
        }
    }
}
