using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace TeretanaMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Gost",
                columns: table => new
                {
                    GostID = table.Column(type: "INTEGER", nullable: false)
                      ,//  .Annotation("Sqlite:Autoincrement", true),
                    ImeIPrezime = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gost", x => x.GostID);
                });
            migration.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikID = table.Column(type: "INTEGER", nullable: false)
                      ,//  .Annotation("Sqlite:Autoincrement", true),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Email = table.Column(type: "TEXT", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    JMBG = table.Column(type: "TEXT", nullable: true),
                    MjestoStanovanja = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    ProgramID = table.Column(type: "INTEGER", nullable: false),
                    RFID = table.Column(type: "TEXT", nullable: true),
                    SpolOsobe = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikID);
                });
            migration.CreateTable(
                name: "Program",
                columns: table => new
                {
                    ProgramId = table.Column(type: "INTEGER", nullable: false)
                        ,//.Annotation("Sqlite:Autoincrement", true),
                    CijenaClanarine = table.Column(type: "TEXT", nullable: false),
                    NazivPrograma = table.Column(type: "TEXT", nullable: true),
                    OpisPrograma = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.ProgramId);
                });
            migration.CreateTable(
                name: "Uposlenik",
                columns: table => new
                {
                    UposlenikID = table.Column(type: "INTEGER", nullable: false)
                      ,//  .Annotation("Sqlite:Autoincrement", true),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Email = table.Column(type: "TEXT", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    JMBG = table.Column(type: "TEXT", nullable: true),
                    MjestoStanovanja = table.Column(type: "TEXT", nullable: true),
                    Password = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    SpolOsobe = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uposlenik", x => x.UposlenikID);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Gost");
            migration.DropTable("Korisnik");
            migration.DropTable("Program");
            migration.DropTable("Uposlenik");
        }
    }
}
