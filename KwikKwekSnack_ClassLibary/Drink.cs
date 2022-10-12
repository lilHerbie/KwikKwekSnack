using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{

    public class Drink: Product
    {
        private Size _size { get; set; }
    }



    enum Size
    {
        S,
        M,
        L,
        XL
    }
}
