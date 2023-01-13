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
        public float TotalCost { get; set; }

        public OrderVM()
        {
            SnackLines = new List<SnackLine>();
            DrinkLines = new List<DrinkLine>();
        }
        
    }
}
