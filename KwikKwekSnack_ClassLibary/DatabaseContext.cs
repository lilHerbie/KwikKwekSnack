using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{
    public class DatabaseContext: DbContext
    {
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
            }
        }
    }
}
