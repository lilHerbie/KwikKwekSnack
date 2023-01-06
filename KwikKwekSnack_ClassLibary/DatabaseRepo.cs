using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{
    public class DatabaseRepo
    {

        DatabaseContext _ctx = new DatabaseContext();

        public void AddSnack(Snack snack)
        {
            _ctx.Snacks.Add(snack);
            _ctx.SaveChanges();
        }

        public void RemoveSnack(Snack snack)
        {
            _ctx.Snacks.Remove(snack);
            _ctx.SaveChanges();
        }

        public void UpdateSnack(Snack snack)
        {
            if (_ctx.Snacks.Contains(snack))
            {
                _ctx.Snacks.Update(snack);
            }
            _ctx.SaveChanges();
        }

        public Snack GetSnack(int id)
        {
            return _ctx.Snacks.Find(id);
        }

        public List<Snack> GetAllSnacks()
        {
            return _ctx.Snacks.ToList();
        }

        public void AddDrink(Drink drink)
        {
            _ctx.Drinks.Add(drink);
            _ctx.SaveChanges();
        }

        public void RemoveDrink(Drink drink)
        {
            _ctx.Drinks.Remove(drink);
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

        public Drink GetDrink(int id)
        {
            return _ctx.Drinks.Find(id);
        }

        public List<Drink> GetAllDrinks()
        {
            return _ctx.Drinks.ToList();
        }

        public void AddExtra(Extra extra)
        {
            _ctx.Extras.Add(extra);
            _ctx.SaveChanges();
        }

        public void RemoveExtra(Extra extra)
        {
            _ctx.Extras.Remove(extra);
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

        public Extra GetExtra(int id)
        {
            return _ctx.Extras.Find(id);
        }

        public List<Extra> GetAllExtras()
        {
            return _ctx.Extras.ToList();
        }

    }
}
