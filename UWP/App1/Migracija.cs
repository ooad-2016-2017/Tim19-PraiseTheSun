using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public partial class Migracija : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
           migration.CreateTable(
           name: "Lokacija",
           columns: table => new
           {
               bazaID = table.Column(type: "INTEGER", nullable: false),
               // .Annotation("Sqlite:Autoincrement", true),
               adresa = table.Column(type: "TEXT", nullable: false),
               tipLokacije = table.Column(type: "locType", nullable: false),
               removed = table.Column(type: "BOOLEAN", nullable: false)
           },
           constraints: table =>
           {
               table.PrimaryKey("PK_Lokacija", x => x.bazaID);
           });

            migration.CreateTable(
           name: "Item",
           columns: table => new
           {
               bazaID = table.Column(type: "INTEGER", nullable: false),
               // .Annotation("Sqlite:Autoincrement", true),
               datumProdaje = table.Column(type: "TEXT", nullable: false),
               trenutnaLokacija = table.Column(type: "INTEGER", nullable: false),
               removed = table.Column(type: "BOOLEAN", nullable: false)
           },
           constraints: table =>
           {
               table.PrimaryKey("PK_Item", x => x.bazaID);
               table.ForeignKey(
                        name: "FK_Lok_Item",
                        columns: x => x.trenutnaLokacija,
                        referencedTable: "Lokacija",
                        referencedColumn: "bazaID");
           });

            migration.CreateTable(
            name: "Artikal",
            columns: table => new
            {
                bazaID = table.Column(type: "INTEGER", nullable: false),
                // .Annotation("Sqlite:Autoincrement", true),
                ime = table.Column(type: "TEXT", nullable: false),
                cijena = table.Column(type: "INTEGER", nullable: false),
                fizicki = table.Column(type: "artType", nullable: false),
                info = table.Column(type: "TEXT", nullable: false),
                slika = table.Column(type: "image", nullable: true),
                removed = table.Column(type: "BOOLEAN", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Artikal", x => x.bazaID);
                table.ForeignKey(
                        name: "FK_Item_Art",
                        columns: x => x.bazaID,
                        referencedTable: "Item",
                        referencedColumn: "bazaID");
            });

            migration.CreateTable(
            name: "Korisnik",
            columns: table => new
            {
                bazaID = table.Column(type: "TEXT", nullable: false),
                // .Annotation("Sqlite:Autoincrement", true),
                //info = table.Column(type: "TEXT", nullable: false),
                username = table.Column(type: "TEXT", nullable: false),
                password = table.Column(type: "TEXT", nullable: false),
                adresa = table.Column(type: "INTEGER", nullable: false),
                slika = table.Column(type: "image", nullable: false),
                tipAccounta = table.Column(type: "accType", nullable: false),
                removed = table.Column(type: "BOOLEAN", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Korisnik", x => x.bazaID);
            });

            migration.CreateTable(
            name: "KolekcijaKorisnika",
            columns: table => new
            {
                id_korisnika = table.Column(type: "INTEGER", nullable: false),
                // .Annotation("Sqlite:Autoincrement", true),
                id_artikla = table.Column(type: "INTEGER", nullable: false),
                removed = table.Column(type: "BOOLEAN", nullable: false)
            },
            constraints: table =>
            {
                table.ForeignKey(
                        name: "FK_Kolek_Kor",
                        columns: x => x.id_korisnika,
                        referencedTable: "Korisnik",
                        referencedColumn: "bazaID");
                table.ForeignKey(
                        name: "FK_Kolek_Art",
                        columns: x => x.id_artikla,
                        referencedTable: "Artikal",
                        referencedColumn: "bazaIdD");
            });

           migration.CreateTable(
           name: "Kritika",
           columns: table => new
           {
               id_korisnika = table.Column(type: "INTEGER", nullable: false),
               // .Annotation("Sqlite:Autoincrement", true),
               id_artikla = table.Column(type: "INTEGER", nullable: false),
               komentar = table.Column(type: "TEXT", nullable: false),
               ocjena = table.Column(type: "INTEGER", nullable: false),
               removed = table.Column(type: "BOOLEAN", nullable: false)
           },
           constraints: table =>
           {
               table.ForeignKey(
                        name: "FK_Krit_Kor",
                        columns: x => x.id_korisnika,
                        referencedTable: "Korisnik",
                        referencedColumn: "bazaID");
               table.ForeignKey(
                       name: "FK_Krit_Art",
                       columns: x => x.id_artikla,
                       referencedTable: "Artikal",
                       referencedColumn: "bazaID");
           });

        }
        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Lokacija");
            migration.DropTable("Item");
            migration.DropTable("Artikal");
            migration.DropTable("Korisnik");
            migration.DropTable("KolekcijaKorisnika");
            migration.DropTable("Kritika");
        }
    }
}
