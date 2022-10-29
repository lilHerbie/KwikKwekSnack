using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{

    public class Drink
    {
        [Key()]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [DataType(DataType.Currency)]
        public decimal StartPrice { get; set; }

    }
}
