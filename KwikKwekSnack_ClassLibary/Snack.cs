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
        public int _startPrice { get; set; }
        public string _name { get; set; }
        public string _description { get; }
        public string _imageUrl { get; set; }
        public double _price { get; set; }
    

    public Snack(int startPrice)
        {
            _startPrice = startPrice;
        }
    }

    
}
