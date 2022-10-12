using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{
    public abstract class Product
    {
        string Name { get; set; }
        string Description { get; }
        string ImageUrl { get; set; }
        int Price { get; set; }
    }
}
