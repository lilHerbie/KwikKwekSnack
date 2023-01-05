using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KwikKwekSnack_ClassLibary;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace KwikKwekSnack_ClassLibary
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }
        public status Status { get; set; }
        //public List<int> DrinkLineIds { get; set; }
        //public List<int> SnackLineIds { get; set; }
        //public virtual List<DrinkLine> Drinks { get; set; }
        //public virtual List<SnackLine> Snacks { get; set; }
        public Order()
        {
            
        }

        public enum status
    {
        wachtrij,
        wordtBereid,
        gereed
    }

    }
}