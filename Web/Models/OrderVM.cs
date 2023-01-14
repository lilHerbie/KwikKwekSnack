using ClassLibrary;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class OrderVM
    {
        public List<SnackLine> SnackLines { get; set; }
        public List<DrinkLine> DrinkLines { get; set; }
        public Status Status { get; set; }
        [DataType(DataType.Currency)]
        public bool TakeAway { get; set; }
        public float TotalCost
        {
            get
            {
                float totalCost = 0;
                foreach (SnackLine snackLine in SnackLines)
                {
                    totalCost += snackLine.TotalPrice;
                }
                foreach (DrinkLine drinkLine in DrinkLines)
                {
                    totalCost += drinkLine.TotalPrice;
                }
                return totalCost;
            }
        }

        public OrderVM()
        {
            SnackLines = new List<SnackLine>();
            DrinkLines = new List<DrinkLine>();
        }
        
    }
}
