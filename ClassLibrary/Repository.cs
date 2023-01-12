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

        public List<Snack> GetSnacks()
        {
            return databaseContext.Snacks.ToList();
        }

        public Snack GetSnackById(int id)
        {
            return databaseContext.Snacks.Where(i => i.Id == id).FirstOrDefault();
        }

        public List<Extra> GetExtras()
        {
            return databaseContext.Extras.ToList();
        }

        public void AddOrder(Order order)
        {
            databaseContext.Orders.Add(order);
        }
    }
}
