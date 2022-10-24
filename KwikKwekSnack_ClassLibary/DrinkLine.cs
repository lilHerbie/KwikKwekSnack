using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{
    public class DrinkLine
    {
        public bool HasStraw { get; set; }
        public bool HasIce { get; set; }
        public int Id { get; set; }
        public Size size { get; set; }
    }

    public enum Size
    {
        S,
        M,
        L,
        XL
    }
}
