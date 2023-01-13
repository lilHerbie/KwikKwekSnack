using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Repository
    {
        DatabaseContext _ctx = new();

        //snacks
        public List<Snack> GetSnacks()
        {
            return _ctx.Snacks.ToList();
        }

        public Snack GetSnackById(int id)
        {
            return _ctx.Snacks.Where(s => s.Id == id).FirstOrDefault();
        }
        
          public void UpdateSnack(Snack snack)
        {
            if (_ctx.Snacks.Contains(snack))
            {
                _ctx.Snacks.Update(snack);
            }
            _ctx.SaveChanges();
        }

        public void RemoveSnack(Snack snack)
        {
            _ctx.Snacks.Remove(snack);
            _ctx.SaveChanges();
        }

        //extras      
        public void AddSnack(Snack snack)
        {
            _ctx.Snacks.Add(snack);
            _ctx.SaveChanges();
        }
        
         public List<Extra> GetExtras()
        {
            return _ctx.Extras.ToList();
        }

        public Extra GetExtraById(int id)
        {
            return _ctx.Extras.Where(e => e.Id == id).FirstOrDefault();
        }

        public void AddExtra(Extra extra)
        {
            _ctx.Extras.Add(extra);
            _ctx.SaveChanges();
        }

        public void UpdateExtra(Extra extra)
        {
            if (_ctx.Extras.Contains(extra))
            {
                _ctx.Extras.Update(extra);
            }

            _ctx.SaveChanges();
        }

        public void RemoveExtra(Extra extra)
        {
            _ctx.Extras.Remove(extra);
            _ctx.SaveChanges();
        }

       
        //drinks
        public List<Drink> GetDrinks()
        {
            return _ctx.Drinks.ToList();
        }

        public Drink GetDrinkById(int id)
        {
            return _ctx.Drinks.Where(d => d.Id == id).FirstOrDefault();
        }

        public void AddDrink(Drink drink)
        {
            _ctx.Drinks.Add(drink);
            _ctx.SaveChanges();
        }

        public void UpdateDrink(Drink drink)
        {
            if (_ctx.Drinks.Contains(drink))
            {
                _ctx.Drinks.Update(drink);
            }

            _ctx.SaveChanges();
        }

        public void RemoveDrink(Drink drink)
        {
            _ctx.Drinks.Remove(drink);
            _ctx.SaveChanges();
        }

        public void AddOrder(Order order)
        {
            _ctx.Orders.Add(order);
        }
    }
}
