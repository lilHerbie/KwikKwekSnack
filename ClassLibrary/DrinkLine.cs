using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DrinkLine
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Drink Drink { get; set; }
        public string DrinkName { get; set; }
        public int DrinkId { get; set; }
        public bool HasStraw { get; set; }
        public bool HasIce { get; set; }
        public Size Size { get; set; }
        
    }

    public enum Size
    {
        S,
        M,
        L,
        XL
    }
}
