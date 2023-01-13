using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public List<SnackLine> SnackLines { get; set; }
        public List<DrinkLine> DrinkLines { get; set; }
        public Status Status { get; set; }
        [DataType(DataType.Currency)]
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
            set
            {

            }
        }

        public Order()
        {
            SnackLines = new List<SnackLine>();
            DrinkLines = new List<DrinkLine>();

        }

    }


    public enum Status
    {
        queued,
        isBeingPrepared,
        ready
    }
}