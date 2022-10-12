using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{
    public abstract class Product
    {
        string _name { get; set; }
        string _description { get; }
        string _imageUrl { get; set; }
        double _price { get; set; }
    }
}
