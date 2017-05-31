using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace App1
{
    class GameShopDbContext : DbContext
    {
        public DbSet<Artikal> Artikli { get; set; }//nasa "tabela?" za artikle
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Lokacija> Lokacije { get; set; }
        public DbSet<Kritika> Kritike { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<KolekcijaKorisnika> Collection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "GameShop.db";
            try
            {                
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, databaseFilePath);
            }
            catch (InvalidOperationException) { }
            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }

    }
}
