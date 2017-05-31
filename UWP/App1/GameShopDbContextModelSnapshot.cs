using Microsoft.Data.Entity.Migrations.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Data.Entity;
using Windows.UI.Xaml.Controls;

namespace App1
{
    [ContextType(typeof(GameShopDbContext))]
    partial class GameShopDbContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("GameShop.Model.Artikal", b =>
            {
                b.Property<int>("bazaID")
                    .ValueGeneratedOnAdd();

                b.Property<String>("ime");

                b.Property<int>("cijena");

                b.Property<artType>("tipArtikla");

                b.Property<Image>("tip");

                b.Property<Boolean>("removed");

                b.Key("bazaID");
            });

            builder.Entity("GameShop.Model.Item", b =>
            {
                b.Property<int>("bazaID")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("datumProdaje");

                b.Property<int>("trenutnaLoakcija");

                b.Property<Boolean>("removed");

                b.Key("bazaID");
            });

            builder.Entity("GameShop.Model.Kritika", b =>
            {
                b.Property<int>("id_korisnika");

                b.Property<int>("id_artikla");

                b.Property<String>("komentar");

                b.Property<int>("ocjena");

                b.Property<Boolean>("removed");
            });

            builder.Entity("GameShop.Model.Korisnik", b =>
            {
                b.Property<int>("bazaID")
                    .ValueGeneratedOnAdd();

                b.Property<String>("username");

                b.Property<String>("pass");

                b.Property<int>("adresa");

                b.Property<Image>("slika");

                b.Property<accType>("tipAccounta");

                b.Property<Boolean>("removed");

                b.Key("bazaID");
            });

            builder.Entity("GameShop.Model.Lokacija", b =>
            {
                b.Property<int>("bazaID")
                    .ValueGeneratedOnAdd();

                b.Property<String>("adresa");

                b.Property<locType>("trenutnaLoakcija");

                b.Property<Boolean>("removed");

                b.Key("bazaID");
            });

            builder.Entity("GameShop.Model.KolekcijaKorisnika", b =>
            {
                b.Property<int>("id_korisnika");

                b.Property<int>("id_artikal");
            });

            builder.Entity("FutureHotel.Model.Item", b =>
            {
                b.Reference("FutureHotel.Model.Lokacija")
                    .InverseCollection()
                    .ForeignKey("trenutnaLoakcija");             
            });

            builder.Entity("FutureHotel.Model.Kritika", b =>
            {
                b.Reference("FutureHotel.Model.Korisnik")
                    .InverseCollection()
                    .ForeignKey("id_korisnika");

                b.Reference("FutureHotel.Model.Item")
                    .InverseCollection()
                    .ForeignKey("id_artikla");
            });

            builder.Entity("FutureHotel.Model.Korisnik", b =>
            {
                b.Reference("FutureHotel.Model.Lokacija")
                    .InverseCollection()
                    .ForeignKey("adresa");
            });

            builder.Entity("FutureHotel.Model.KolekcijaKorisnika", b =>
            {
                b.Reference("FutureHotel.Model.Korisnik")
                    .InverseCollection()
                    .ForeignKey("id_korisnika");

                b.Reference("FutureHotel.Model.Item")
                    .InverseCollection()
                    .ForeignKey("id_artikla");
            });
        }
    }
}
