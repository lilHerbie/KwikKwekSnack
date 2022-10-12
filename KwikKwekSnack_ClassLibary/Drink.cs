using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{

    public class Drink: Product
    {
        public int DrinkId { get; set; }
        private Size Size { get; set; }
    }

    public enum Size
    {
        S,
        M,
        L,
        XL
    }
}
