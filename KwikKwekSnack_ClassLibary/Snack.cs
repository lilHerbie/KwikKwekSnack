using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{
    public class Snack
    {
        public int Id { get; set; }
        public double StartPrice { get; set; }
        public string Name { get; set; }
        public string Description { get; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }


    }
}
