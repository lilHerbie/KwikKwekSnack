using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KwikKwekSnack_ClassLibary;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace KwikKwekSnack_ClassLibary
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }
        public status Status { get; set; }

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