using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{
    public abstract class Product
    {
        public string Name { get; set; }
        public string Description { get; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
    }
}
