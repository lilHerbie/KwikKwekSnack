using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{

    public class Drink
    {
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public string Description { get; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public Size Size { get; set; }
        public bool Ice { get; set; }
        public bool Straw { get; set; }
    }

    public enum Size
    {
        S,
        M,
        L,
        XL
    }
}
