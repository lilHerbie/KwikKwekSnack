using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{
    public class DrinkLine
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool HasStraw { get; set; }
        public bool HasIce { get; set; } 
        public Size Size { get; set; }
        [ForeignKey("DrinkId")]
        public int DrinkId { get; set; }
        public Drink Drink { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public int Amount { get; set; }
    }

    public enum Size
    {
        S,
        M,
        L,
        XL
    }
}
