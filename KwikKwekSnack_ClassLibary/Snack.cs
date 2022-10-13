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
        public int SnackId { get;set; }
        public string Name { get; set; }
        public string Description { get; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public List<Extra> Extras { get; set; }
        public int StartPrice { get; set; }

    }
}
