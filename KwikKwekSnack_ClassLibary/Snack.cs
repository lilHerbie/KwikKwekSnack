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
        public int SnackId { get; set; }
        public Extra extra { get; set; }
        public int StartPrice { get; set; }

      /*  public Snack(int startPrice)
        {
            this.StartPrice = startPrice; 
        }*/
    }

    public enum Extra
    {
        kaas,
        sla,
        uit,
        tomaat
    }
}
