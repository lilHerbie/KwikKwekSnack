using Microsoft.EntityFrameworkCore;
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
        public DbSet<ExtraLine> ExtraLines { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=KwikKwekSnack;Trusted_Connection=true;TrustServerCertificate=True;");
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //test data
            Drink drink1 = new() { Id = -1, Name = "Cola", Description = "Cola", ImageUrl = "https://smartkiosk.nl/wp-content/uploads/2021/11/coca-cola-blik-33cl-800x800-1.jpg", Price = 1.60f };
            Drink drink2 = new() { Id = -2, Name = "Fanta", Description = "Fanta", ImageUrl = "https://smartkiosk.nl/wp-content/uploads/2021/10/9480.jpg", Price = 1.50f };
            Drink drink3 = new() { Id = -3, Name = "Sprite", Description = "Sprite", ImageUrl = "https://smartkiosk.nl/wp-content/uploads/2021/09/2ad47881-f56c-4237-8574-402a84b96b63.jpg", Price = 1.50f };
            Drink drink4 = new() { Id = -4, Name = "Bier", Description = "Bier", ImageUrl = "https://www.plus.nl/INTERSHOP/static/WFS/PLUS-Site/-/PLUS/nl_NL/product/L/853866.png", Price = 1.50f };
            Drink drink5 = new() { Id = -5, Name = "Baco", Description = "Baco", ImageUrl = "https://goedkoopdrankslijterij.nl/image/cache/catalog/Sterke%20drank/Rum/bacardi/Bacardi-Cola-Mix-Blikjes-kopen-800x800.jpg", Price = 3.50f };
            Drink drink6 = new() { Id = -6, Name = "Stroh80", Description = "Stroh80", ImageUrl = "https://static.gall.nl/images/IMG_685854_500.png?rev=0.2", Price = 5.00f };

            Snack snack1 = new() { Id = -1, Name = "Frikandel", Description = "Frikandel", ImageUrl = "https://boshuis.huisjebezorgd.nl/wp-content/uploads/2020/03/29512948_652505005141152_1601506864166600704_o.jpg", Price = 2.50f };
            Snack snack2 = new() { Id = -2, Name = "Kroket", Description = "Kroket", ImageUrl = "https://images0.persgroep.net/rcs/IFZ8aVdFNg1-Bko2qCSQg5i8G-A/diocontent/101162365/_fitwidth/763?appId=93a17a8fd81db0de025c8abd1cca1279&quality=0.8", Price = 2.75f };
            Snack snack3 = new() { Id = -3, Name = "Bamischijf", Description = "Bamischijf", ImageUrl = "https://veluwe-plaza.huisjebezorgd.nl/wp-content/uploads/2020/03/bami.jpg", Price = 3.00f };
            Snack snack4 = new() { Id = -4, Name = "Kaassouflé", Description = "Kaassouflé", ImageUrl = "https://www.ahealthylife.nl/wp-content/uploads/2021/06/Kaassouffle_voedingswaarde-1.jpg", Price = 4.50f };
            Snack snack5 = new() { Id = -5, Name = "Mexicano", Description = "Mexicano", ImageUrl = "https://mexicano.nl/wp-content/uploads/Mexicano-630x312.png", Price = 2.50f };
            Snack snack6 = new() { Id = -6, Name = "Friet", Description = "Friet", ImageUrl = "https://www.ahealthylife.nl/wp-content/uploads/2019/05/patat_friet_voedingswaarde.jpg", Price = 1.50f };

            Extra extra1 = new() { Id = -1, Name = "Ui", Price = 0.30f };
            Extra extra2 = new() { Id = -2, Name = "Broodje", Price = 1.00f };
            Extra extra3 = new() { Id = -3, Name = "Tomaat", Price = 0.20f };
            Extra extra4 = new() { Id = -4, Name = "Mayonaise", Price = 0.50f };
            Extra extra5 = new() { Id = -5, Name = "Ketchup", Price = 0.50f };

            ExtraLine extraLine1 = new() { Id = -1, ExtraId = -1, SnackLineId = -1 };
            ExtraLine extraLine2 = new() { Id = -2, ExtraId = -2, SnackLineId = -2 };
            ExtraLine extraLine3 = new() { Id = -3, ExtraId = -4, SnackLineId = -3 };

            SnackLine snackLine1 = new() { Id = -1, OrderId = -1, SnackId = -1, Amount = 1 };
            SnackLine snackLine2 = new() { Id = -2, OrderId = -2, SnackId = -3, Amount = 2 };
            SnackLine snackLine3 = new() { Id = -3, OrderId = -3, SnackId = -4, Amount = 1 };

            DrinkLine drinkLine1 = new() { Id = -1, OrderId = -1, DrinkId = -1, Amount = 1, HasStraw = true, HasIce = true, Size = Size.S };
            DrinkLine drinkLine2 = new() { Id = -2, OrderId = -2, DrinkId = -4, Amount = 32, HasStraw = true, HasIce = false, Size = Size.XL };
            DrinkLine drinkLine3 = new() { Id = -3, OrderId = -2, DrinkId = -5, Amount = 32, HasStraw = true, HasIce = true, Size = Size.XL };
            DrinkLine drinkLine4 = new() { Id = -4, OrderId = -3, DrinkId = -2, Amount = 1, HasStraw = false, HasIce = false, Size = Size.M };

            Order order1 = new Order() { Id = -1, Status = Status.queued, TotalCost = 4.40f };
            Order order2 = new Order() { Id = -2, Status = Status.queued, TotalCost = 62.00f };
            Order order3 = new Order() { Id = -3, Status = Status.queued, TotalCost = 20.00f };


            modelBuilder.Entity<Drink>().HasData(drink1, drink2, drink3, drink4, drink5, drink6);
            modelBuilder.Entity<Snack>().HasData(snack1, snack2, snack3, snack4, snack5, snack6);
            modelBuilder.Entity<Extra>().HasData(extra1, extra2, extra3, extra4, extra5);

            modelBuilder.Entity<SnackLine>().HasData(snackLine1, snackLine2, snackLine3);
            modelBuilder.Entity<DrinkLine>().HasData(drinkLine1, drinkLine2, drinkLine3, drinkLine4);
            modelBuilder.Entity<ExtraLine>().HasData(extraLine1, extraLine2, extraLine3);

            modelBuilder.Entity<Order>().HasData(order1, order2, order3);

        }
    }
}
