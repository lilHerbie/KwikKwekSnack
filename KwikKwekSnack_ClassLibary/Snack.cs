using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{
    public class Snack : Product
    {
        private List<Extra>_extras;
        private int _startPrice;

        public Snack(int startPrice)
        {
            _startPrice = startPrice;

        }
    }

    public enum Extra
    {
        kaas,
        sla,
        uit,
        tomaat
    }
}
