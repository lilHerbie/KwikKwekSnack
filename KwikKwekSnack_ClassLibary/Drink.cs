using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{

    public class Drink
    {
        public Size _size { get; set; }
        public string _name { get; set; }
        public string _description { get; }
        public string _imageUrl { get; set; }
        public double _price { get; set; }
    }
}



    enum Size
    {
        S,
        M,
        L,
        XL
    }
}
