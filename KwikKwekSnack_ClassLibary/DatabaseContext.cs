using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{
    public class DatabaseContext: DbContext
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

            

            Order order1 = new() { Id = 1, Status = Order.status.wachtrij, TotalPrice = 10.00m };
            Order order2 = new() { Id = 2, Status = Order.status.wachtrij, TotalPrice = 10.00m };

            DrinkLine order1DrinkLine1 = new() { OrderId = 1, Id = 1, DrinkId = 1, amount = 2, Size = Size.M, HasStraw = false, HasIce = false, Price = 3.00m };
            DrinkLine order1DrinkLine2 = new() { OrderId = 1, Id = 2, DrinkId = 2, amount = 1, Size = Size.L, HasStraw = true, HasIce = false, Price = 1.50m };
            DrinkLine order2DrinkLine1 = new() { OrderId = 2, Id = 3, DrinkId = 3, amount = 1, Size = Size.XL, HasStraw = true, HasIce = false, Price = 1.50m };
            
            SnackLine order1SnackLine1 = new() { OrderId = 1, Id = 1, /*Snack = snack1,*/ SnackId = 1, amount = 2, Price = 5.00m};
            SnackLine order1SnackLine2 = new() { OrderId = 2, Id = 2,/* Snack = snack2,*/ SnackId = 2, amount = 1, Price = 2.75m};
            SnackLine order2SnackLine1 = new() { OrderId = 2, Id = 3, /*Snack = snack3,*/SnackId = 3, amount = 1, Price = 2.75m};

            Extra extra1 = new() { Id = 1, Name = "Ui", Price = 0.30m, SnackLineId = 1};
            Extra extra2 = new() { Id = 2, Name = "Broodje", Price = 1.00m, SnackLineId = 2 };
            Extra extra3 = new() { Id = 3, Name = "Tomaat", Price = 0.20m, SnackLineId = 3 };




            #endregion

            #region databuilder
            modelBuilder.Entity<Drink>().HasData(drink1, drink2, drink3);
            modelBuilder.Entity<Snack>().HasData(snack1, snack2, snack3);
            modelBuilder.Entity<Extra>().HasData(extra1, extra2, extra3);


            modelBuilder.Entity<DrinkLine>().HasData(order1DrinkLine1, order1DrinkLine2, order2DrinkLine1);
            modelBuilder.Entity<SnackLine>().HasData(order1SnackLine1, order1SnackLine2, order2SnackLine1);

            modelBuilder.Entity<Order>().HasData(order1, order2);

            /*modelBuilder.Entity<Drink>().Property(d => d.StartPrice).HasPrecision(12, 2);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DrinkLine>().Property(dl => dl.Price).HasPrecision(12, 2);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Snack>().Property(d => d.StartPrice).HasPrecision(12, 2);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SnackLine>().Property(sl => sl.Price).HasPrecision(12, 2);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>().Property(o => o.TotalPrice).HasPrecision(12, 2);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Extra>().Property(e => e.Price).HasPrecision(12, 2);

            base.OnModelCreating(modelBuilder);*/

            #endregion


        }

    }
}
