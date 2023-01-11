using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public ICollection<SnackLine> SnackLines { get; set; }
        public Status Status { get; set; }
        [DataType(DataType.Currency)]
        public decimal TotalCost { get; set; }

    }

    public enum Status
    {
        wachtrij,
        wordtBereid,
        gereed
    }
}