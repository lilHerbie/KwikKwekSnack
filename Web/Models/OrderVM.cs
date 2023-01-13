using ClassLibrary;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class OrderVM
    {
        public ICollection<SnackLine> SnackLines { get; set; }
        public ICollection<DrinkLine> DrinkLines { get; set; }
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
