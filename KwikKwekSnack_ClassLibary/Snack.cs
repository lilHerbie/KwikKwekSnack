using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using KwikKwekSnack_ClassLibary;

namespace KwikKwekSnack_ClassLibary
{
    public class Snack
    {
        [Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal StartPrice { get; set; }
        


    }
}
