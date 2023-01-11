using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<DrinkLine> DrinkLines { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Snack> Snacks { get; set; }
        public DbSet<SnackLine> SnackLines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=KwikKwekSnackDB;Trusted_Connection=true;");
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region testdata

            Drink drink1 = new() { Id = 1, Name = "Cola", Description = "Cola", ImageUrl = "https://smartkiosk.nl/wp-content/uploads/2021/11/coca-cola-blik-33cl-800x800-1.jpg", StartPrice = 1.50m };
            Drink drink2 = new() { Id = 2, Name = "Fanta", Description = "Fanta", ImageUrl = "https://smartkiosk.nl/wp-content/uploads/2021/10/9480.jpg", StartPrice = 1.50m };
            Drink drink3 = new() { Id = 3, Name = "Sprite", Description = "Sprite", ImageUrl = "https://smartkiosk.nl/wp-content/uploads/2021/09/2ad47881-f56c-4237-8574-402a84b96b63.jpg", StartPrice = 1.50m };

            Snack snack1 = new() { Id = 1, Name = "Frikandel", Description = "Frikandel", ImageUrl = "https://boshuis.huisjebezorgd.nl/wp-content/uploads/2020/03/29512948_652505005141152_1601506864166600704_o.jpg", StartPrice = 2.50m };
            Snack snack2 = new() { Id = 2, Name = "Kroket", Description = "Kroket", ImageUrl = "https://images0.persgroep.net/rcs/IFZ8aVdFNg1-Bko2qCSQg5i8G-A/diocontent/101162365/_fitwidth/763?appId=93a17a8fd81db0de025c8abd1cca1279&quality=0.8", StartPrice = 2.75m };
            Snack snack3 = new() { Id = 3, Name = "Bamischijf", Description = "Bamischijf", ImageUrl = "https://veluwe-plaza.huisjebezorgd.nl/wp-content/uploads/2020/03/bami.jpg", StartPrice = 3.00m };
            #endregion
        }
    }
}

