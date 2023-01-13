﻿using Microsoft.EntityFrameworkCore;
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
            Drink drink1 = new() { Id = 1, Name = "Cola", Description = "Cola", ImageUrl = "https://smartkiosk.nl/wp-content/uploads/2021/11/coca-cola-blik-33cl-800x800-1.jpg", Price = 1.60f };
            Drink drink2 = new() { Id = 2, Name = "Fanta", Description = "Fanta", ImageUrl = "https://smartkiosk.nl/wp-content/uploads/2021/10/9480.jpg", Price = 1.50f };
            Drink drink3 = new() { Id = 3, Name = "Sprite", Description = "Sprite", ImageUrl = "https://smartkiosk.nl/wp-content/uploads/2021/09/2ad47881-f56c-4237-8574-402a84b96b63.jpg", Price = 1.50f };

            Snack snack1 = new() { Id = 1, Name = "Frikandel", Description = "Frikandel", ImageUrl = "https://boshuis.huisjebezorgd.nl/wp-content/uploads/2020/03/29512948_652505005141152_1601506864166600704_o.jpg", Price = 2.50f };
            Snack snack2 = new() { Id = 2, Name = "Kroket", Description = "Kroket", ImageUrl = "https://images0.persgroep.net/rcs/IFZ8aVdFNg1-Bko2qCSQg5i8G-A/diocontent/101162365/_fitwidth/763?appId=93a17a8fd81db0de025c8abd1cca1279&quality=0.8", Price = 2.75f };
            Snack snack3 = new() { Id = 3, Name = "Bamischijf", Description = "Bamischijf", ImageUrl = "https://veluwe-plaza.huisjebezorgd.nl/wp-content/uploads/2020/03/bami.jpg", Price = 3.00f };

            Extra extra1 = new() { Id = 1, Name = "Ui", Price = 0.30f };
            Extra extra2 = new() { Id = 2, Name = "Broodje", Price = 1.00f };
            Extra extra3 = new() { Id = 3, Name = "Tomaat", Price = 0.20f };

            ExtraLine extraLine1 = new () { Id = 1, ExtraId = 1, SnackLineId = 1, ExtraName = "Ui"};

            SnackLine snackLine1 = new() { Id = 1, OrderId = 1, SnackId = 1, SnackName = "Frikandel", Amount = 1};

            DrinkLine drinkLine1 = new() { Id = 1, OrderId = 1, DrinkId = 1, DrinkName = "Cola", Amount = 1 };

            Order order1 = new Order() { Id = 1, Status = Status.queued };


            modelBuilder.Entity<Drink>().HasData(drink1, drink2, drink3);
            modelBuilder.Entity<Snack>().HasData(snack1, snack2, snack3);
            modelBuilder.Entity<Extra>().HasData(extra1, extra2, extra3);

            modelBuilder.Entity<SnackLine>().HasData(snackLine1);
            modelBuilder.Entity<DrinkLine>().HasData(drinkLine1);
            modelBuilder.Entity<ExtraLine>().HasData(extraLine1);

            modelBuilder.Entity<Order>().HasData(order1);

        }
    }
}
