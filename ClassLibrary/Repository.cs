using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Repository
    {
        DatabaseContext databaseContext = new();

        //snacks
        public List<Snack> GetSnacks()
        {
            return databaseContext.Snacks.ToList();
        }

        public Snack GetSnackById(int id)
        {
            return databaseContext.Snacks.Where(i => i.Id == id).FirstOrDefault();
        }

        //extras
        public List<Extra> GetExtras()
        {
            return databaseContext.Extras.ToList();
        }
        public Extra GetExtraById(int id)
        {
            return databaseContext.Extras.Where(i => i.Id == id).FirstOrDefault();
        }

       
        //drinks
        public List<Drink> GetDrinks()
        {
            return databaseContext.Drinks.ToList();
        }
        public Drink GetDrinkById(int id)
        {
            return databaseContext.Drinks.Where(i => i.Id == id).FirstOrDefault();
        }

        public void AddOrder(Order order)
        {
            databaseContext.Orders.Add(order);
        }
    }
}
